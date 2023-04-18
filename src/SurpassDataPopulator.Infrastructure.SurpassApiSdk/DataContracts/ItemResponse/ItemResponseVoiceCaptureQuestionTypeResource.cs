using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse
{
    [DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
    public class ItemResponseVoiceCaptureQuestionTypeResource : ItemResponseBaseResource
    {
        [DataMember(Name = ApiConsts.Members.Response, EmitDefaultValue = false)]
        public string Response { get; set; }

        [DataMember(Name = ApiConsts.Members.FileType, EmitDefaultValue = false)]
        public string FileType { get; set; }
    }
}
