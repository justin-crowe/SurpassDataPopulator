using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting;

[DataContract(Name = ApiConsts.Contracts.RatingMethod, Namespace = "")]
public class RatingMethodDetailedResource : RatingMethodResource
{
    [DataMember(Name = ApiConsts.Members.Name, Order = 1)]
    public string Name { get; set; }
}