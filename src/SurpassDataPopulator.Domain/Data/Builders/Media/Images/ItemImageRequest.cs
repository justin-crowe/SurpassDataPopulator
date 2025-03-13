using System.Collections.Generic;

namespace SurpassDataPopulator.Domain.Data.Builders.Media.Images;

public record ItemImageRequest(int NumberOfImages, bool FixedImageCountPerItem, Dictionary<string, byte[]> ImageLookup)
{
    public int NumberOfImages = NumberOfImages;
    public bool FixedImageCountPerItem = FixedImageCountPerItem;
    public Dictionary<string, byte[]> ImageLookup = ImageLookup;
}