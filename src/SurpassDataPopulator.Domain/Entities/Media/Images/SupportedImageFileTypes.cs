using System.Collections.Generic;

namespace SurpassDataPopulator.Domain.Entities.Media.Images;

public static class SupportedImageFileTypes
{
    public static List<string> FileTypes { get; } = ["jpg", "jpeg", "png", "svg"];
}