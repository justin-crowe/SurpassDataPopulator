using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Response
{
    [DataContract(Name = ApiConsts.Contracts.Response, Namespace = "")]
    public class ItemDeleteTimeZonePostResponseModel : TimeZonePostResponseModel
    {
        [DataMember(Name = ApiConsts.Members.PermanentlyDeleted)]
        public bool PermanentlyDeleted { get; set; }
    }
}
