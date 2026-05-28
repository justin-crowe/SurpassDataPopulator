using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Refit;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Infrastructure.Http;
using SurpassDataPopulator.Infrastructure.Services.Surpass.Api.V2;
using System;
using System.Net.Http;
using System.Text;

namespace SurpassDataPopulator.Infrastructure.Services.Surpass;

public class SurpassApiServiceFactory : ISurpassApiServiceFactory
{
    private readonly ICredentialsStore _credentialsStore;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly RefitSettings _refitSettings;

    public SurpassApiServiceFactory(ICredentialsStore credentialsStore, RefitSettings refitSettings, IHttpClientFactory httpClientFactory)
    {
        _refitSettings = refitSettings;
        _credentialsStore = credentialsStore;
        _httpClientFactory = httpClientFactory;
    }

    public static string HttpClientName => "SurpassApiClient";

    public ISurpassApiService GetService()
    {
        var credentials = _credentialsStore.Load();
        if(credentials == null) throw new InvalidOperationException("Credentials not found. Please ensure you have logged in or configured the Surpass API credentials.");

        var httpClient = _httpClientFactory.CreateClient(HttpClientName);
        httpClient.BaseAddress = new Uri(credentials.Url);

        var authValue = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{credentials.Username}:{credentials.Password}"));
        httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authValue);

        var apiV2 = RestService.For<ISurpassV2Api>(httpClient, _refitSettings);
        return new SurpassApiService(apiV2);
    }
}