using SurpassDataPopulator.Domain.Authentication;

namespace SurpassDataPopulator.Application.Interfaces.Services;

public interface ICredentialsStore
{
    void StageNewCredentials(Credentials credentials);
    void Save(Credentials credentials);
    Credentials? Load();
    void Delete();
}