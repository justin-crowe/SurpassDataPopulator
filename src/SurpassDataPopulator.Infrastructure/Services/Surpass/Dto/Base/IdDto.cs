using System.Text.Json.Serialization;

namespace SurpassDataPopulator.Infrastructure.Services.Surpass.Dto.Base;

public class IdDto
{
    [JsonPropertyName("id")] 
    public int? Id { get; set; }
}