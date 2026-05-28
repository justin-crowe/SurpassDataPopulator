using System.Collections.Generic;
using SurpassDataPopulator.Domain.Data.Builders.ItemTags;
using SurpassDataPopulator.Domain.Data.Builders.Media.Images;

namespace SurpassDataPopulator.Domain.Data.Builders.Items;

public class ItemBuildRequest
{
    public ItemBuildRequest(int numberOfItemsPerCategory, List<int> categories, bool displayCorrectAnswer = true, IEnumerable<TagRequest> tags = null, ItemImageRequest imageRequest = null)
    {
        Categories = categories;
        NumberOfItemsPerCategory = numberOfItemsPerCategory;
        DisplayCorrectAnswer = displayCorrectAnswer;
        Tags = tags;
        ImageRequest = imageRequest;
    }
        
    public int NumberOfItemsPerCategory { get; }
    public List<int> Categories { get; }
    public bool DisplayCorrectAnswer { get; }
    public IEnumerable<TagRequest> Tags { get; }
    public ItemImageRequest ImageRequest { get; set; }
}