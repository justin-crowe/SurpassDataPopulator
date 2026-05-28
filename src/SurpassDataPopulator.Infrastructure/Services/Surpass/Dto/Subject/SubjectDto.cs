using System.Text.Json.Serialization;

namespace SurpassDataPopulator.Infrastructure.Services.Surpass.Dto.Subject;

public class SubjectDto
{
    [JsonPropertyName("reference")] 
    public string Reference { get; set; }
}