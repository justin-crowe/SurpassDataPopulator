namespace SurpassDataPopulator.Application.Interfaces.Services;

public interface ISurpassApiServiceFactory
{
    public ISurpassApiService GetService();
}