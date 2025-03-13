using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.User;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IUserResourceController
{
    TimeZonePostResponseModel Delete(string reference);

    TimeZonePostResponseModel Delete(int id);

    TimeZonePageResponse<UserResource> Get(string queryString = null);

    TimeZonePageResponse<UserDetailedResource> Get(long id, bool showPermissions = false);

    TimeZonePageResponse<UserDetailedResource> GetByReference(string reference, bool showPermissions = false);

    TimeZonePostResponseModel Post(UserCreateResource user);

    TimeZonePostResponseModel Put(
        string reference,
        UserUpdateResource user,
        IEnumerable<HttpHeader> headers = null);

    TimeZonePostResponseModel Put(long id, UserUpdateResource user, IEnumerable<HttpHeader> headers = null);
}