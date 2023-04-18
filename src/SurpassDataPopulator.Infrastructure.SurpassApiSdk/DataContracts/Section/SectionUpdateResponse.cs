using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Section
{
    public class SectionUpdateResponse : PostResponseModel
    {
        [DataMember(Name = ApiConsts.Members.TestFormId, Order = 1)]
        public int TestFormId { get; set; }
    }
}
