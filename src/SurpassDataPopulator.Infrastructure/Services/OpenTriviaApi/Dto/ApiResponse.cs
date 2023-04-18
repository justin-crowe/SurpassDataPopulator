using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi.Dto
{
    public record ApiResponse
    {
        [JsonPropertyName("response_code")]
        public int ResponseCode { get; set; }

        [JsonPropertyName("results")]
        public IReadOnlyList<QuestionResponse> OpenTriviaQuestions { get; set; }
    }
}