using System;
using System.Collections.Generic;
using System.IO;

namespace SurpassDataPopulator.Domain.Entities.Media.Images;

public class MediaImage : MediaItem
{
    public MediaImage()
    {
    }

    public MediaImage(byte[] image, string name)
    {
        Image = image;
        Name = name;
        FileName = Path.GetFileName(Name);
    }

    public MediaImage(KeyValuePair<string, byte[]> kvPair)
    {
        Image = kvPair.Value;
        Name = kvPair.Key;
        FileName = Path.GetFileName(Name);
    }

    public string Name { get; set; }

    /// <summary>
    /// Filename with extension of the image file
    /// </summary>
    public string FileName { get; set; }

    public byte[] Image { get; set; }

    public long Id { get; set; }

    public string ToBase64()
    {
        return Convert.ToBase64String(Image);
    }
}