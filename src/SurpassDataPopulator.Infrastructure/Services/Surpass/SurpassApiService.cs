using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
using SurpassApiSdk.DataContracts.Folder;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.DataContracts.ItemTagValue;
using SurpassApiSdk.DataContracts.TagGroup;
using SurpassApiSdk.DataContracts.TagValue;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Domain.Entities.Items;
using SurpassDataPopulator.Domain.Entities.Tags;
using SurpassDataPopulator.Infrastructure.Services.Surpass.Api.V2;
using SurpassDataPopulator.Infrastructure.Services.Surpass.Mapping;
using TagGroupResource = SurpassApiSdk.DataContracts.ItemTagValue.TagGroupResource;

namespace SurpassDataPopulator.Infrastructure.Services.Surpass
{
    public class SurpassApiService : ISurpassApiService
    {
        private readonly ISurpassV2Api _surpassV2Api;

        public SurpassApiService(ISurpassV2Api surpassV2Api)
        {
            _surpassV2Api = surpassV2Api;
        }
        public async Task<bool> SubjectExistsAsync(string subjectRef)
        {
            var result = await _surpassV2Api.SubjectSearch(subjectRef);
            if (result.Errors != null && result.Errors.Any()) throw new Exception($"Error(s) while getting the subject {subjectRef}: {result.Errors.Humanize()}");
            return result.Response.Count() == 1;
        }

        public async Task CreateItemsAsync(List<Item> items, string subjectReference)
        {
            //create all the tags
            var tagGroupLookup = await CreateTagGroupsForItems(items, subjectReference);

            //create folders for each category
            var folderLookup = await CreateFoldersForItems(items, subjectReference);

            //create the items into the correct folder and add tag values
            var itemLookup = await CreateItemsInFolders(folderLookup, items, subjectReference);
            
            //assign the tags
            await AssignTagsToItems(items, itemLookup, tagGroupLookup, subjectReference);

            //set them to live OR bulk update?
            //await SetItemStatus(items, subjectReference, ItemStatus.Live);

            //TODO set the LO to the category?
        }

        private async Task AssignTagsToItems(List<Item> items, Dictionary<long, Item> itemLookup, Dictionary<string, long> tagGroupLookup, string subjectReference)
        {
            var tagValueLookup = await AssignTagValuesToTagGroups(itemLookup, tagGroupLookup, subjectReference);
            await AssignTagValuesToItems(itemLookup, tagGroupLookup, tagValueLookup, subjectReference);
        }

        private async Task AssignTagValuesToItems(Dictionary<long, Item> items, Dictionary<string, long> tagGroupLookup, Dictionary<string, long> tagValueLookup, string subjectReference)
        {
            foreach (var (key, value) in items)
            {
                //Assign each tag to the item
                foreach (var tag in value.Tags)    
                {
                    //Find the tagGroupId and tagValueId to assign for each item
                    var tagGroupId = tagGroupLookup[tag.Name];
                    var tagValueId = tagValueLookup[tag.Name + "-" + tag.Value];
                    var itemTagValue = new ItemTagValueInputResource
                    {
                        TagGroup = new TagGroupResource { Id = tagGroupId },
                        Item = new SubjectItemTagValueResource { Id = key },
                        TagValue = new SubjectTagValueResource { Id = tagValueId }
                    };
                    
                    var response = await _surpassV2Api.ItemTagValue(itemTagValue);
                    if (response.Errors != null && response.Errors.Any()) throw new Exception($"Error(s) while creating the tag value: {response.Errors.Humanize()}");
                    if (response.Id == null) throw new Exception($"Error(s) while creating the tag value. Response Id was null");
                }  
            }
        }

        private async Task<Dictionary<string, long>> AssignTagValuesToTagGroups(Dictionary<long, Item> items,
            Dictionary<string, long> tagGroupLookup, string subjectReference)
        {
            //Get the current tag values in the subject.
            //TODO Get current tag values ana make sure we dont remake any that already exist.
            var tagValuesInSubject = await _surpassV2Api.TagValuesInSubject(subjectReference);
            var currentSubjectTagValues = new Dictionary<string, long>(); //tagValuesInSubject.Response.ToDictionary(x => x.TagValue, x => x.Id.Value);

            // Get the distinct values/names required and then filter based on values that already exist
            // We could share values across groups.. but not sure there is a benefit and it makes this code much more complicated
            // var distinctTagValues2 = items.SelectMany(x => x.Value.Tags).DistinctBy(t => t.Value).ToList();
            var distinctTagValues = items.SelectMany(x => x.Value.Tags).DistinctBy(t => new {t.Value, t.Name }).ToList();
            var requiredTagValues = distinctTagValues.Where(t => currentSubjectTagValues.All(ct => ct.Key != t.Value)).ToList();

            //Add the required tag values to the corresponding group
            var tagValueLookup = new Dictionary<string, long>();
            foreach (var requiredTagValue in requiredTagValues)
            {
                var tagGroupId = tagGroupLookup[requiredTagValue.Name];
                    
                var tagValue = new TagValueInputResource
                {
                    TagGroup = new TagValueGroupResource
                    {
                        Id = tagGroupId
                    },
                    TagValue = requiredTagValue.Value
                };
                var response = await _surpassV2Api.TagValue(tagValue);
                if (response.Errors != null && response.Errors.Any()) throw new Exception($"Error(s) while creating the tag value: {response.Errors.Humanize()}");
                if (response.Id == null) throw new Exception($"Error(s) while creating the tag value. Response Id was null");
                var tagValueId = response.Id.Value;
                tagValueLookup.Add(requiredTagValue.Name + "-" + requiredTagValue.Value, tagValueId);
            }

            return tagValueLookup;
        }

        private async Task<Dictionary<long, Item>> CreateItemsInFolders(Dictionary<string, long> folderLookup, List<Item> items, string subjectReference)
        {
            var itemLookup = new Dictionary<long, Item>();
            foreach (var folder in folderLookup)
            {
                var itemsForFolder = items.Where(i => i.Category == folder.Key).ToList();
                for (var index = 0; index < itemsForFolder.Count; index++)
                {
                    var item = itemsForFolder[index];
                    var position = index + 1;
                    var itemPost = item.ToSurpassPostDto(subjectReference, folder.Value, position);
                    var response = await _surpassV2Api.Item(itemPost);
                    if (response.Errors != null && response.Errors.Any()) throw new Exception($"Error(s) while creating the item: {response.Errors.Humanize()}");
                    if (response.Id == null) throw new Exception($"Error(s) while creating the item. Response Id was null");
                    itemLookup.Add(response.Id.Value, item);
                }
            }
            return itemLookup;
        }

        private async Task<Dictionary<string, long>> CreateFoldersForItems(List<Item> items, string subjectReference)
        {
            var allCategories = new List<string>();
            items.ForEach(i =>
            {
                allCategories.Add(i.Category);
            });
            var distinctCategories = allCategories.Distinct();
            
            var subjectFolders = await _surpassV2Api.FolderSearch(subjectReference);
            if (subjectFolders.Errors != null && subjectFolders.Errors.Any()) throw new Exception($"Error from surpass api: {subjectFolders.Errors.Humanize()}");

            var folderLookup = subjectFolders.Response.Where(x => !x.Deleted)
                .ToDictionary(folderResource => folderResource.Name, folderResource => (long) folderResource.Id);

            foreach (var category in distinctCategories) 
            {
                long folderId = -1;

                if (folderLookup.Any(x => x.Key == category)) continue;
                
                var postBody = new FolderInputResource
                {
                    Name = category,
                    Subject = new ItemSubjectResource
                    {
                        Reference = subjectReference
                    }
                };
                var folderResult = await _surpassV2Api.Folder(postBody);
                if (folderResult.Errors != null && folderResult.Errors.Any()) throw new Exception($"Error from surpass api: {folderResult.Errors.Humanize()}");
                if (folderResult.Id != null)
                {
                    folderId = folderResult.Id.Value;
                    folderLookup.Add(category, folderId);
                }
                else
                {
                    throw new Exception($"Unable to find id for folder {category}");
                }
                
            }

            return folderLookup;
        }

        private async Task<Dictionary<string, long>> CreateTagGroupsForItems(List<Item> items, string subjectReference)
        {
            var tagGroupIdLookup = new Dictionary<string, long>();
            var allTags = new List<Tag>();
            items.ForEach(i =>
            {
                allTags.AddRange(i.Tags);
            });
            var distinctTagGroups = allTags.DistinctBy(t => t.Name);

            foreach (var distinctTagGroup in distinctTagGroups)
            {
                var exists = false;
                long tagId = -1;
                var response = await _surpassV2Api.TagGroupSearch(distinctTagGroup.Name, subjectReference);
                if (response.Errors != null && response.Errors.Any()) throw new Exception($"Error from surpass api: {response.Errors}");
                
                if (response.Count >= 1)
                {
                    //there might be multiple since we have to use a contains function.. ugh..
                    var tag = response.Response.FirstOrDefault(x => x.Name == distinctTagGroup.Name);
                    if (tag == null) throw new ArgumentException($"Cannot find tag with name {distinctTagGroup.Name}");
                    exists = true;
                    if (tag.Id != null) tagId = tag.Id.Value;
                }
                
                if (!exists)
                {
                    var postBody = new TagGroupInputResource
                    {
                        Name = distinctTagGroup.Name, 
                        TagTypeValue = TagGroupTagTypeValueKey.Text,
                        AuthorCreation = true,
                        Subject = new ItemSubjectResource
                        {
                            Reference = subjectReference
                        }
                    };
                    var tagResult = await _surpassV2Api.TagGroup(postBody);
                    if (tagResult.Id != null) tagId = tagResult.Id.Value;
                }
                
                if (tagId == -1) throw new Exception($"Id for tag group {distinctTagGroup} couldn't be created/found. Its still -1.");

                tagGroupIdLookup.Add(distinctTagGroup.Name, tagId);
            }

            return tagGroupIdLookup;
        }
    }
}