using System.Threading.Tasks;
using Refit;
using SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi.Dto;

namespace SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi;

public interface IOpenTriviaApi
{
    /// <summary>
    /// Uses the OpenTrivia Api to generate items<br/>
    /// https://opentdb.com/api_config.php<br/>
    /// Use type=boolean to get just eitherOr. type=multiple to get just mcq. Blank to get a mixture.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [Get("/api.php")]
    Task<ApiResponse> GetTriviaQuestions(OpenTriviaApiRequest request);
}

public class OpenTriviaApiRequest
{
    [AliasAs("amount")]
    public int Amount { get; set; }
        
    /// <param name="category">opentrivia category numbers:<br/>
    ///   null - Any<br/>
    ///   9 - General Knowledge<br/>
    ///   10 - Entertainment: Books<br/>
    ///   11 - Entertainment: Film<br/>
    ///   12 - Entertainment: Music<br/>
    ///   13 - Entertainment: Musicals &amp; Theatres<br/>
    ///   14 - Entertainment: Television<br/>
    ///   15 - Entertainment: Video Games<br/>
    ///   16 - Entertainment: Board Games<br/>
    ///   17 - Science &amp; Nature<br/>
    ///   18 - Science: Computers<br/>
    ///   19 - Science: Mathematics<br/>
    ///   20 - Mythology<br/>
    ///   21 - Sports<br/>
    ///   22 - Geography<br/>
    ///   23 - History<br/>
    ///   24 - Politics<br/>
    ///   25 - Art<br/>
    ///   26 - Celebrities<br/>
    ///   27 - Animals<br/>
    ///   28 - Vehicles<br/>
    ///   29 - Entertainment: Comics<br/>
    ///   30 - Science: Gadgets<br/>
    ///   31 - Entertainment: Japanese Anime &amp; Manga<br/>
    ///   32 - Entertainment: Cartoon &amp; Animations</param>
    [AliasAs("category")]
    public int? Category { get; set; }
}