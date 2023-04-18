using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse
{
    [DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
    public class ItemResponseFileAttachQuestionTypeResource : ItemResponseBaseResource
    {
        [DataMember(Name = ApiConsts.Members.Files)]
        public List<FileResponse> Files { get; set; }
    }
}
