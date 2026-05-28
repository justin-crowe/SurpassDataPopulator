using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Humanizer;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.DataContracts.Item.Details.Items;
using SurpassDataPopulator.Domain.Entities.Items;
using SurpassDataPopulator.Domain.Entities.Items.QuestionTypes.EitherOr;
using SurpassDataPopulator.Domain.Entities.Items.QuestionTypes.MultipleChoice;
using SurpassDataPopulator.Domain.Entities.Tags;

namespace SurpassDataPopulator.Infrastructure.Services.Surpass.Mapping;

public static class DomainSurpassMappingExtensions
{
    public static ItemInputResource ToSurpassPostDto(this Item item, string subjectReference, long folderId, int position)
    {
        var postObject = CreateStandardItem(item, subjectReference, folderId, position);
            
        switch (item)
        {
            case EitherOrItem eitherOrItem:
                CreateEitherOrResource(eitherOrItem, postObject);
                break;
            case MultipleChoiceItem mcq:
                CreateMcqResource(mcq, postObject);
                break;
            default:
                throw new ArgumentException($"Unable to create item of type: {item.GetType()}");
        }

        return postObject;
    }

    private static void CreateMcqResource(MultipleChoiceItem mcq, ItemInputResource postObject)
    {
        var mcqOptions = mcq.AnswerOptions.Select(
            (option, index) => new ItemOptionUpdateResource
            {
                Correct = option.CorrectAnswer,
                Text = $"{option.Text}",
                Id = index,
            }).ToList();

        postObject.MultipleChoiceQuestions = new List<MultipleChoiceItemUpdateResource>
        {
            new()
            {
                Randomise = true,
                OptionList = new ItemOptionListUpdateResource
                {
                    Options = mcqOptions
                }
            }
        };
    }

    private static void CreateEitherOrResource(EitherOrItem eitherOrItem, ItemInputResource postObject)
    {
        var options = new List<bool> { true, false };
        var eitherOrOptions = options.Select(o => new ItemOptionUpdateResource
        {
            Correct = o == eitherOrItem.CorrectAnswer, 
            Text = $"{o.ToString().Humanize(LetterCasing.Title)}",
        }).ToList();

        postObject.EitherOrQuestions = new List<EitherOrItemUpdateResource>
        {
            new()
            {
                Randomise = true,
                OptionList = new EOItemOptionListUpdateResource()
                {
                    Options = eitherOrOptions
                }
            }
        };
    }

    private static ItemInputResource CreateStandardItem(Item item, string subjectReference, long folderId, int position)
    {
        var stems = new StringBuilder();
        foreach (var questionText in item.QuestionText)
        {
            stems.Append($"{questionText}");
        }

        AddTagsDescriptionToStem(stems, item.Tags);

        return new ItemInputResource
        {
            Subject = new ItemSubjectResource
            {
                Reference = subjectReference
            },
            Folder = new ItemFolderResource
            {
                Id = (int) folderId,
                Position = position
            },
            //StemComponents = item.QuestionText.Select(questionText => new MultimediaComponentResource { Text = questionText }).ToList(),
            QuestionText = stems.ToString(),
            Name = $"{item.Category.Dehumanize()} - item {Guid.NewGuid().ToString("N")} - {item.Difficulty} Difficulty",
            Mark = item.Mark,
            ItemKind = ItemKind.Question,
            MediaItems = AddMediaToItem(item)
        };
    }

    private static IEnumerable<MediaItemDetailResource> AddMediaToItem(Item item)
    {
        var media = new List<MediaItemDetailResource>();
        if (item.MediaImages.Any())
        {
            media.AddRange(item.MediaImages.Select(itemMediaImage => new MediaItemDetailResource
                {
                    Id = (int) itemMediaImage.Id
                }));
        }

        return media;
    }

    private static void AddTagsDescriptionToStem(StringBuilder stems, List<Tag> itemTags)
    {
        // Add a table for all tags
        stems.Append($"<br/><table border=\"2\" style=\"width:100%\"><thead><tr><th colspan=\"2\">Tags</th></tr></thead><tbody>");
        foreach (var tag in itemTags)
        {
            stems.Append($"<tr><td>{tag.Name}</td><td>{tag.Value}</td></tr>");
        }
        stems.Append("</tbody></table>");
    }
}