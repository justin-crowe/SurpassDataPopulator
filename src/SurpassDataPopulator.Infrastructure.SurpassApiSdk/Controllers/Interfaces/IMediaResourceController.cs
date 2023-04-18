using SurpassApiSdk.DataContracts.Media;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface IMediaResourceController
    {
        PostResponseModel Post(MediaInputResource mediaInput);

        TimeZonePageResponse<MediaDetailedResource> GetById(int id);

        Stream GetDataById(int id);
    }
}
