using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SurpassDataPopulator.Infrastructure.Services.Surpass.Dto;

public class SurpassApiResponse<T>
{
    [JsonPropertyName("count")]
    public int Count { get; set; }
        
    [JsonPropertyName("top")]
    public int Top { get; set; }
        
    [JsonPropertyName("skip")]
    public int Skip { get; set; }
        
    [JsonPropertyName("pageCount")]
    public int PageCount { get; set; }
        
    [JsonPropertyName("nextPageLink")]
    public object NextPageLink { get; set; }
        
    [JsonPropertyName("prevPageLink")]
    public object PrevPageLink { get; set; }
        
    [JsonPropertyName("response")]
    public List<T> Response { get; set; }
        
    [JsonPropertyName("errors")]
    public object Errors { get; set; }
        
    [JsonPropertyName("serverTimeZone")]
    public string ServerTimeZone { get; set; }
}

public class Response
{
    public string name { get; set; }
    public string tagTypeKey { get; set; }
    public int id { get; set; }
    public string href { get; set; }
}