namespace SurpassDataPopulator.Infrastructure.Services.Surpass;

public class SurpassApiOptions
{
    public static string ConfigSectionName => "SurpassApi";

    public string BaseUrl { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}