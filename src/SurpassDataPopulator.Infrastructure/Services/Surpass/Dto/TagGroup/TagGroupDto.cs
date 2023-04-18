using System.Text.Json.Serialization;
using SurpassDataPopulator.Infrastructure.Services.Surpass.Dto.Subject;

namespace SurpassDataPopulator.Infrastructure.Services.Surpass.Dto.TagGroup;

public class TagGroupDto
{
    public TagGroupDto(string name, string tagTypeValue, string subjectRef)
    {
        Name = name;
        TagTypeValue = tagTypeValue;
        Subject = new SubjectDto {Reference = subjectRef};
    }

    [JsonPropertyName("subject")] 
    public SubjectDto Subject { get; set; }

    [JsonPropertyName("name")] 
    public string Name { get; set; }

    [JsonPropertyName("tagTypeValue")] 
    public string TagTypeValue { get; set; } = "Text";
}