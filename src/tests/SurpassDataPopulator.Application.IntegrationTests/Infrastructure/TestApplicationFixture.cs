using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Infrastructure;
using SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi;

namespace SurpassDataPopulator.Application.IntegrationTests.Infrastructure;

/// <summary>
/// Base fixture for integration tests that sets up the service container with real Application/Domain services
/// and mocked Infrastructure services for external APIs.
/// </summary>
public class TestApplicationFixture : IDisposable
{
    public IServiceProvider ServiceProvider { get; private set; }
    public Mock<ISurpassApiService> MockSurpassApiService { get; private set; }
    public Mock<IOpenTriviaApi> MockOpenTriviaApi { get; private set; }
    public Mock<IItemGeneratorService> MockItemGeneratorService { get; private set; }
    public Mock<IFileStorage> MockFileStorage { get; private set; }
    public Mock<ICredentialsStore> MockCredentialsStore { get; private set; }
    public Mock<ISessionManager> MockSessionManager { get; private set; }

    public TestApplicationFixture()
    {
        SetupMocks();
        ServiceProvider = BuildServiceProvider();
    }

    private void SetupMocks()
    {
        MockSurpassApiService = new Mock<ISurpassApiService>();
        MockOpenTriviaApi = new Mock<IOpenTriviaApi>();
        MockItemGeneratorService = new Mock<IItemGeneratorService>();
        MockFileStorage = new Mock<IFileStorage>();
        MockCredentialsStore = new Mock<ICredentialsStore>();
        MockSessionManager = new Mock<ISessionManager>();
    }

    private IServiceProvider BuildServiceProvider()
    {
        var services = new ServiceCollection();

        // Configuration
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.Test.json", optional: true)
            .AddInMemoryCollection(new Dictionary<string, string>
            {
                ["SurpassApi:BaseUrl"] = "https://test.surpass.com",
                ["SurpassApi:Username"] = "testuser",
                ["SurpassApi:Password"] = "testpass",
                ["OpenTriviaApi:BaseUrl"] = "https://opentdb.com"
            })
            .Build();

        services.AddSingleton<IConfiguration>(configuration);

        // Register Application layer (includes MediatR, validators, behaviors, and Domain builders)
        services.AddApplication();

        // Register Infrastructure with mocked external services
        services.AddInfrastructure(configuration);

        // Override Infrastructure services with mocks
        OverrideWithMocks(services);

        return services.BuildServiceProvider();
    }

    private void OverrideWithMocks(ServiceCollection services)
    {
        // Remove real implementations and add mocks
        services.RemoveAll<ISurpassApiService>();
        services.AddSingleton(MockSurpassApiService.Object);

        services.RemoveAll<ISurpassApiServiceFactory>();
        var mockFactory = new Mock<ISurpassApiServiceFactory>();
        mockFactory.Setup(x => x.GetService()).Returns(MockSurpassApiService.Object);
        services.AddSingleton(mockFactory.Object);

        services.RemoveAll<IOpenTriviaApi>();
        services.AddSingleton(MockOpenTriviaApi.Object);

        services.RemoveAll<IItemGeneratorService>();
        services.AddSingleton(MockItemGeneratorService.Object);

        services.RemoveAll<IFileStorage>();
        services.AddSingleton(MockFileStorage.Object);

        services.RemoveAll<ICredentialsStore>();
        services.AddSingleton(MockCredentialsStore.Object);

        services.RemoveAll<ISessionManager>();
        services.AddSingleton(MockSessionManager.Object);
    }

    public IMediator GetMediator() => ServiceProvider.GetRequiredService<IMediator>();

    public T GetService<T>() where T : notnull => ServiceProvider.GetRequiredService<T>();

    public void ResetMocks()
    {
        MockSurpassApiService.Reset();
        MockOpenTriviaApi.Reset();
        MockItemGeneratorService.Reset();
        MockFileStorage.Reset();
        MockCredentialsStore.Reset();
        MockSessionManager.Reset();
    }

    public void Dispose()
    {
        if (ServiceProvider is IDisposable disposable)
        {
            disposable.Dispose();
        }
    }
}

public static class ServiceCollectionExtensions
{
    public static void RemoveAll<T>(this IServiceCollection services)
    {
        var descriptor = services.FirstOrDefault(d => d.ServiceType == typeof(T));
        if (descriptor != null)
        {
            services.Remove(descriptor);
        }
    }
}
