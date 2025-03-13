using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.TestSchedule;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface ITestScheduleResourceController
{
    TimeZonePostResponseModel Delete(string keycode);

    TimeZonePostResponseModel Delete(int id);

    TestSchedulePostResponseModel Post(
        TestScheduleResource testSchedule,
        IEnumerable<HttpHeader> headers = null,
        bool quickRegisterCandidate = false);
}