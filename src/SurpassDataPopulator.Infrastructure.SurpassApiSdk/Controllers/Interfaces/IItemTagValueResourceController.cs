using SurpassApiSdk.DataContracts.ItemTagValue;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IItemTagValueResourceController
{
    PostResponseModel Delete(ItemTagValueInputResource itemTagValueInput);

    PostResponseModel Post(ItemTagValueInputResource itemTagValueInput);

    TimeZonePageResponse<SubjectTagValueItemResource> Get(long id);
}