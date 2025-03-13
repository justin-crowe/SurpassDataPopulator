using System.Collections.Generic;

namespace SurpassDataPopulator.Domain.Entities.Media.Images;

public static class SupportedImageFileTypes
{
    public static List<string> FileTypes { get; } = new()
    {
        "jpg", "jpeg", "png", "gif", "bmp", "tiff", "tif", "svg"
    };
}