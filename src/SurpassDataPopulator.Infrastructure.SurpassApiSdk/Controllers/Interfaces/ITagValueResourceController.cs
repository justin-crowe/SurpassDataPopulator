using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.TagValue;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface ITagValueResourceController
    {
        TimeZonePageResponse<TagValueResource> Get(long id);

        TimeZonePageResponse<TagValueManyResource> Get(string queryString = null);

        PostResponseModel Post(TagValueInputResource tagValueInput);

        PostResponseModel Put(int id, TagValueUpdateResource tagValueInput);
    }
}
