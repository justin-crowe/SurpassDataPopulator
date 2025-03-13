using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi.Dto;

public record QuestionResponse
{
    [JsonPropertyName("category")]
    public string Category { get; set; }
        
    [JsonPropertyName("type")]
    public string Type { get; set; }
        
    [JsonPropertyName("difficulty")]
    public QuestionDifficulty Difficulty { get; set; }
        
    [JsonPropertyName("question")]
    public string Question { get; set; }
        
    [JsonPropertyName("correct_answer")]
    public string CorrectAnswer { get; set; }
        
    [JsonPropertyName("incorrect_answers")]
    public IReadOnlyList<string> IncorrectAnswers { get; set; }
}