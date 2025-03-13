using System.Collections.Generic;
using System.IO;
using System.Linq;
using SurpassDataPopulator.Application.Interfaces.Services;

namespace SurpassDataPopulator.Infrastructure.Services.FileStorage;

public class FileStorage : IFileStorage
{
    public void SaveFile(string path, byte[] file)
    {
        throw new System.NotImplementedException();
    }

    public byte[] ReadAllBytes(string path)
    {
        return File.ReadAllBytes(path);
    }

    public List<string> GetFiles(string directoryPath)
    {
        return new List<string>(Directory.GetFiles(directoryPath));
    }

    public List<string> GetFiles(string directoryPath, List<string> supportedFileTypes)
    {
        return Directory.GetFiles(directoryPath).Where(file => supportedFileTypes.Any(ext => file.EndsWith($".{ext}"))).ToList();
    }
}