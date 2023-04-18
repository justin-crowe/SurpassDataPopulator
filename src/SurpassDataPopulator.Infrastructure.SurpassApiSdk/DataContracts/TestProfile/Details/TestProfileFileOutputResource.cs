using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestProfile.Details
{
    [DataContract(Name = ApiConsts.Contracts.TestProfile, Namespace = "")]
    public class TestProfileFileOutputResource
    {
        [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = true)]
        public int Id { get; set; }

        [DataMember(Name = ApiConsts.Members.FileUrl, EmitDefaultValue = true)]
        public string FileUrl { get; set; }

        [DataMember(Name = ApiConsts.Members.FileName, EmitDefaultValue = true)]
        public string FileName { get; set; }
    }
}
