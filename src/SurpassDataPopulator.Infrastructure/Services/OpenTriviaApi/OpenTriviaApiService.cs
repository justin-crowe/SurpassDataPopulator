using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Domain.Data.Builders.Items;
using SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi.Dto;
using SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi.Mapping;

namespace SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi
{
    public class OpenTriviaApiService : IItemGeneratorService
    {
        private readonly IOpenTriviaApi _openTriviaApi;
        
        public OpenTriviaApiService(IOpenTriviaApi openTriviaApi)
        {
            _openTriviaApi = openTriviaApi;
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

                    openTriviaResponses.Add(response);
                }
            }

            return openTriviaResponses;
        }
    }
}