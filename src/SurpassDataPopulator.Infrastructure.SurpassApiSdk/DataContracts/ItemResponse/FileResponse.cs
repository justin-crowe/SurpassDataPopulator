using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse
{
    [DataContract(Name = ApiConsts.Contracts.File, Namespace = "")]
    public class FileResponse
    {
        [DataMember(Name = ApiConsts.Members.FileName, Order = 1, EmitDefaultValue = false)]
        public string FileName { get; set; }

        [DataMember(Name = ApiConsts.Members.Content, Order = 2, EmitDefaultValue = false)]
        public string Content { get; set; }
    }
}
