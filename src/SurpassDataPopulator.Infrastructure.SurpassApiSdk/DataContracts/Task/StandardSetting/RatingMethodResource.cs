using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting
{
    [DataContract(Name = ApiConsts.Contracts.RatingMethod, Namespace = "")]
    public class RatingMethodResource
    {
        [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
        public int Id { get; set; }
    }
}
