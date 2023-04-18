using System.Collections.Generic;
using SurpassDataPopulator.Domain.Data.Builders.ItemTags;

namespace SurpassDataPopulator.Domain.Data.Builders.Items
{
    public class ItemBuildRequest
    {
        public ItemBuildRequest(int numberOfItemsPerCategory, List<int> categories, bool displayCorrectAnswer = true, IEnumerable<TagRequest> tags = null)
        {
            Categories = categories;
            NumberOfItemsPerCategory = numberOfItemsPerCategory;
            DisplayCorrectAnswer = displayCorrectAnswer;
            Tags = tags;
        }

        public int NumberOfItemsPerCategory { get; }
        public List<int> Categories { get; }
        public bool DisplayCorrectAnswer { get; }
        public IEnumerable<TagRequest> Tags { get; }
    }
}