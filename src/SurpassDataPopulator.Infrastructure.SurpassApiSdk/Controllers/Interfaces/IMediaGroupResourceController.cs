using SurpassApiSdk.DataContracts.MediaGroup;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface IMediaGroupResourceController
    {
        PostResponseModel Post(MediaGroupInputResource mediaGroupInput);

        TimeZonePageResponse<MediaGroupDetailedResource> GetById(int id);

        PostResponseModel Put(int id, MediaGroupUpdateResource mediaGroup);
    }
}
