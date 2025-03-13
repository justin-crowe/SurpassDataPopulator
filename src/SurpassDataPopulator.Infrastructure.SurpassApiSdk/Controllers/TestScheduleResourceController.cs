using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.TestSchedule;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.Models;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class TestScheduleResourceController : ITestScheduleResourceController
{
    private const string QuickRegisterCandidateHeader = "quickRegisterCandidate";

    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassApiUrlFormatter _urlFormatter;

    internal TestScheduleResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    /// <summary>
    /// Create test schedule resource in the database.
    /// </summary>
    /// <param name="testSchedule">Test schedule details</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TestSchedulePostResponseModel Post(
        TestScheduleResource testSchedule,
        IEnumerable<HttpHeader> headers = null,
        bool quickRegisterCandidate = false)
    {
        if (quickRegisterCandidate)
        {
            var quickRegisterCandidateHeader = new HttpHeader()
            {
                Name = QuickRegisterCandidateHeader, Value = "true"
            };
            if (headers == null)
            {
                headers = new List<HttpHeader>() { quickRegisterCandidateHeader };
            }
            else if (!headers.Any(i => i.Name == QuickRegisterCandidateHeader))
            {
                headers.Append(quickRegisterCandidateHeader);
            }
        }

        return _restApiClient.CallPost<TestSchedulePostResponseModel, TestScheduleResource>(
            _urlFormatter.Get(),
            testSchedule,
            headers);
    }

    /// <summary>
    /// Delete test schedule by id.
    /// </summary>
    /// <param name="id">Test schedule id</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Delete(int id)
    {
        return _restApiClient.CallDelete<TimeZonePostResponseModel>(_urlFormatter.GetForId(id));
    }

    /// <summary>
    /// Delete test schedule by keycode.
    /// </summary>
    /// <param name="keycode">Test schedule keycode</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Delete(string keycode)
    {
        return _restApiClient.CallDelete<TimeZonePostResponseModel>(_urlFormatter.GetForKeycode(keycode));
    }
}