using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Domain.Data.Builders.Items;
using SurpassDataPopulator.Infrastructure.Http;
using SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi.Dto;
using SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi.Mapping;

namespace SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi;

public class OpenTriviaApiService : IItemGeneratorService
{
    private readonly IOpenTriviaApi _openTriviaApi;
    private readonly ILogger<OpenTriviaApiService> _logger;

    public OpenTriviaApiService(IOpenTriviaApi openTriviaApi, ILogger<OpenTriviaApiService> logger)
    {
        _openTriviaApi = openTriviaApi;
        _logger = logger;
    }
        
    public async Task<ItemBuildResult> GenerateItemsAsync(ItemBuildRequest request)
    {
        // TODO validate

        //categories is optional, so if its not provided we still need to call the api
        var categories = request.Categories.Any() ? request.Categories : new List<int>{ default };
            
        //generate the questions for all categories
        var openTriviaResponses = await CallOpenTriviaForCategories(request.NumberOfItemsPerCategory, categories);

        return openTriviaResponses.ToItemGenerationResult(request);
    }

    private async Task<List<ApiResponse>> CallOpenTriviaForCategories(int numberOfItemsPerCategory, List<int> categories)
    {
        var openTriviaResponses = new List<ApiResponse>();
            
        //if the amount is > 50 then we need to make multiple requests to the api
        const int maxNumberOfQuestions = 50;
        var requestsRequired = (numberOfItemsPerCategory - 1) / maxNumberOfQuestions + 1;
            
        const int waitBetweenCalls = 5000;

        if (requestsRequired > 1)
        {
            _logger.LogInformation($"Calls to open-trivia are heavily rate limited, so we will wait {waitBetweenCalls / 1000} seconds between calls to avoid 429s. It may take longer to generate the items.");
        }
            
        foreach (var category in categories)
        {
            for (var i = 0; i < requestsRequired; i++)
            {
                var response = await _openTriviaApi.GetTriviaQuestions(new OpenTriviaApiRequest
                {
                    Amount = numberOfItemsPerCategory,
                    Category = category != 0 ? category : null
                });
                    
                if (response.ResponseCode != 0)
                    throw new Exception($"Open trivia api error, response code was {response.ResponseCode}");

                await Task.Delay(waitBetweenCalls);

                openTriviaResponses.Add(response);
            }
        }

        return openTriviaResponses;
    }
}