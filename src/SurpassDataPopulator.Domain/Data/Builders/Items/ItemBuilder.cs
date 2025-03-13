using System.Collections.Generic;
using System.Linq;
using SurpassDataPopulator.Domain.Common.Utilities;
using SurpassDataPopulator.Domain.Data.Builders.Media.Images;
using SurpassDataPopulator.Domain.Entities.Media.Images;

namespace SurpassDataPopulator.Domain.Data.Builders.Items;

public interface IItemBuilder
{
    void AddItemContent(ItemBuildResult builtItems, ItemImageRequest imageRequest);
}

public class ItemBuilder : IItemBuilder
{
    public void AddItemContent(ItemBuildResult builtItems, ItemImageRequest imageRequest)
    {
        foreach (var item in builtItems.Items)
        {
            if (imageRequest.FixedImageCountPerItem)
            {
                item.MediaImages = AssignRandomImages(imageRequest.ImageLookup, imageRequest.NumberOfImages);
            }
            else
            {
                var numberOfMediaItems = imageRequest.NumberOfImages == 0 
                    ? 0 : ThreadSafeRandom.ThisThreadsRandom.Next(imageRequest.NumberOfImages + 1);

                if (numberOfMediaItems == 0)
                {
                    continue;
                }

                item.MediaImages = AssignRandomImages(imageRequest.ImageLookup, numberOfMediaItems);
            }
        }
    }

    private static List<MediaImage> AssignRandomImages(Dictionary<string, byte[]> imageLookup, int numberOfImages)
    {
        return imageLookup
            .OrderBy(_ => ThreadSafeRandom.ThisThreadsRandom.Next())
            .Take(numberOfImages)
            .Select(kvp => new MediaImage(kvp))
            .ToList();
    }
}
