using System.Collections.Generic;

namespace SurpassDataPopulator.Application.Interfaces.Services;

public interface IFileStorage
{
    byte[] ReadAllBytes(string path);

    List<string> GetFiles(string directoryPath, List<string> supportedFileTypes);
}