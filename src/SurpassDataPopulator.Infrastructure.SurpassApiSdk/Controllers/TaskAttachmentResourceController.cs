using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class TaskAttachmentResourceController : ITaskAttachmentResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassTaskAttachmentUrlFormatter _reviewUrlFormatter;
        private readonly ISurpassTaskAttachmentUrlFormatter _authoringUrlFormatter;
        private readonly ISurpassTaskAttachmentUrlFormatter _standardSettingUrlFormatter;

        internal TaskAttachmentResourceController(
            IRestApiClient restApiClient,
            ISurpassTaskAttachmentUrlFormatter reviewUrlFormatter,
            ISurpassTaskAttachmentUrlFormatter authoringUrlFormatter,
            ISurpassTaskAttachmentUrlFormatter standardSettingUrlFormatter)
        {
            _restApiClient = restApiClient;
            _reviewUrlFormatter = reviewUrlFormatter;
            _authoringUrlFormatter = authoringUrlFormatter;
            _standardSettingUrlFormatter = standardSettingUrlFormatter;
        }

        public Stream GetForItemReview(long taskId, long id)
        {
            return _restApiClient.CallGetStream(_reviewUrlFormatter.GetForTaskAttachmentId(taskId, id));
        }

        public Stream GetForItemReviewZip(long taskId)
        {
            return _restApiClient.CallGetStream(_reviewUrlFormatter.GetForTaskId(taskId));
        }

        public Stream GetForItemAuthoring(long taskId, long id)
        {
            return _restApiClient.CallGetStream(_authoringUrlFormatter.GetForTaskAttachmentId(taskId, id));
        }

        public Stream GetForItemAuthoringZip(long taskId)
        {
            return _restApiClient.CallGetStream(_authoringUrlFormatter.GetForTaskId(taskId));
        }

        public Stream GetForStandardSetting(long taskId, long id)
        {
            return _restApiClient.CallGetStream(_standardSettingUrlFormatter.GetForTaskAttachmentId(taskId, id));
        }

        public Stream GetForStandardSettingZip(long taskId)
        {
            return _restApiClient.CallGetStream(_standardSettingUrlFormatter.GetForTaskId(taskId));
        }

        public TimeZonePostResponseModel PostForItemReview(long taskId, string fileName, Stream stream)
        {
            using (var requestContent = GetDataContent(fileName, stream))
            {
                return _restApiClient.CallPostFile<TimeZonePostResponseModel>(
                    _reviewUrlFormatter.GetForTaskId(taskId),
                    requestContent);
            }
        }

        public TimeZonePostResponseModel PostForItemAuthoring(long taskId, string fileName, Stream stream)
        {
            using (var requestContent = GetDataContent(fileName, stream))
            {
                return _restApiClient.CallPostFile<TimeZonePostResponseModel>(
                    _authoringUrlFormatter.GetForTaskId(taskId),
                    requestContent);
            }
        }

        public TimeZonePostResponseModel PostForStandardSetting(long taskId, string fileName, Stream stream)
        {
            using (var requestContent = GetDataContent(fileName, stream))
            {
                return _restApiClient.CallPostFile<TimeZonePostResponseModel>(
                    _standardSettingUrlFormatter.GetForTaskId(taskId),
                    requestContent);
            }
        }

        public TimeZonePostResponseModel DeleteForItemReview(long taskId, long id)
        {
            return _restApiClient.CallDelete<TimeZonePostResponseModel>(
                _reviewUrlFormatter.GetForTaskAttachmentId(taskId, id));
        }

        public TimeZonePostResponseModel DeleteForItemAuthoring(long taskId, long id)
        {
            return _restApiClient.CallDelete<TimeZonePostResponseModel>(
                _authoringUrlFormatter.GetForTaskAttachmentId(taskId, id));
        }

        public TimeZonePostResponseModel DeleteForStandardSetting(long taskId, long id)
        {
            return _restApiClient.CallDelete<TimeZonePostResponseModel>(
                _standardSettingUrlFormatter.GetForTaskAttachmentId(taskId, id));
        }

        private static MultipartFormDataContent GetDataContent(string fileName, Stream stream)
        {
            return new MultipartFormDataContent
            {
                {
#pragma warning disable CA2000 // Disposed by parent MultipartFormDataContent
                    new StreamContent(stream),
#pragma warning restore CA2000 // Disposed by parent MultipartFormDataContent
                    "file",
                    fileName
                }
            };
        }
    }
}
