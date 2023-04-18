using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface ITaskAttachmentResourceController
    {
        Stream GetForItemReview(long taskId, long id);

        Stream GetForItemReviewZip(long taskId);

        Stream GetForItemAuthoring(long taskId, long id);

        Stream GetForItemAuthoringZip(long taskId);

        TimeZonePostResponseModel PostForItemReview(long taskId, string fileName, Stream stream);

        TimeZonePostResponseModel PostForItemAuthoring(long taskId, string fileName, Stream stream);

        TimeZonePostResponseModel DeleteForItemReview(long taskId, long id);

        TimeZonePostResponseModel DeleteForItemAuthoring(long taskId, long id);

        TimeZonePostResponseModel DeleteForStandardSetting(long taskId, long id);

        TimeZonePostResponseModel PostForStandardSetting(long taskId, string fileName, Stream stream);

        Stream GetForStandardSettingZip(long taskId);

        Stream GetForStandardSetting(long taskId, long id);
    }
}
