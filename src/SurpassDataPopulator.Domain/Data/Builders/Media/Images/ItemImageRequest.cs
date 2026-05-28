using System.Collections.Generic;

namespace SurpassDataPopulator.Domain.Data.Builders.Media.Images;

/// <summary>
/// Request for adding images to items. Items can have a fixed number of images or a variable number up to the specified count.
/// </summary>
/// <param name="NumberOfImages"></param>
/// <param name="FixedImageCountPerItem"></param>
/// <param name="ImageLookup"></param>
public record ItemImageRequest(int NumberOfImages, bool FixedImageCountPerItem, Dictionary<string, byte[]> ImageLookup)
{
    public int NumberOfImages = NumberOfImages;

    /// <summary>
    /// If true, each item gets exactly NumberOfImages assigned. If false, each item gets between 0 and NumberOfImages assigned.
    /// </summary>
    public bool FixedImageCountPerItem = FixedImageCountPerItem;
    public Dictionary<string, byte[]> ImageLookup = ImageLookup;
}