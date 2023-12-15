using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SurpassDataPopulator.Domain.Data.Builders.ItemTags;
using SurpassDataPopulator.Domain.Data.Builders.ItemTags.Adaptive;
using SurpassDataPopulator.Domain.Data.Builders.ItemTags.General;
using SurpassDataPopulator.Domain.Entities.Items;

namespace SurpassDataPopulator.Domain.Data.Builders.Items.Adaptive
{
    public interface IAdaptiveItemBuilder 
    {
        void AddAdaptiveContent(List<Item> items, List<string> languageVariants);
    }

    public class AdaptiveItemBuilder : IAdaptiveItemBuilder
    {
        private readonly ITagApplicator _tagApplicator;

        public AdaptiveItemBuilder(ITagApplicator tagApplicator)
        {
            _tagApplicator = tagApplicator;
        }
        
        public void AddAdaptiveContent(List<Item> items, List<string> languageVariants)
        {
            var newVariantItems = new ConcurrentBag<Item>();

            Parallel.ForEach(items, item =>
            {
                //Apply the required adaptive tags
                _tagApplicator.Apply(item, new AdaptiveTagRequirements());
                
                if (!languageVariants.Any()) return;
                
                // if language variants are used, then copy all items and assign required metadata
                CreateLanguageVariant(languageVariants, item, newVariantItems);
            });
            
            //Add the new items to the original list
            items.AddRange(newVariantItems);
        }

        private void CreateLanguageVariant(List<string> languageVariants, Item item, ConcurrentBag<Item> newVariantItems)
        {
            //Generate shared meta data
            var variantLinkage = Guid.NewGuid().ToString("N");
            _tagApplicator.Apply(item, new GeneralTagRequirement(
                new TagRequest(AdaptiveTagNames.MasterId, variantLinkage)));

            //Create copies for each additional lang variant/code
            for (var i = 1; i < languageVariants.Count; i++)
            {
                var languageVariant = languageVariants[i];

                var copy = item.DeepCopy();
                _tagApplicator.Apply(copy, new GeneralTagRequirement(
                    new TagRequest(AdaptiveTagNames.Language, languageVariant)));

                newVariantItems.Add(copy);
            }

            //Add the variant tag linkage to the original item
            var originalLanguageCode = languageVariants.First();
            
            //add a table to show the linkage between the variants
            var languageVariantsLinkageTable = 
                $"<table border=\"2\" style=\"width:100%\">" +
                $"  <thead>" +
                $"      <tr><th colspan=\"3\">Language Variants</th></tr>" +
                $"  </thead>" +
                $"  <tbody>" +
                $"      <tr><td>Language Variants List</td><td>{string.Join(',', languageVariants)}</td></tr>" +
                $"      <tr><td>This Item LanguageCode</td><td>{originalLanguageCode}</td></tr>" +
                $"      <tr><td>{AdaptiveTagNames.MasterId}</td><td><i>{variantLinkage}</i></td></tr>" +
                $"  </tbody>" +
                $"</table>";
            
            item.QuestionText.Add(languageVariantsLinkageTable);
            
            _tagApplicator.Apply(item, new GeneralTagRequirement(
                new TagRequest(AdaptiveTagNames.Language, originalLanguageCode)));
        }
    }
}