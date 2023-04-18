namespace SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi
{
    public class OpenTriviaApiOptions
    {
        public static string ConfigSectionName => "OpenTriviaApi";

        public string BaseUrl { get; set; }
    }
}