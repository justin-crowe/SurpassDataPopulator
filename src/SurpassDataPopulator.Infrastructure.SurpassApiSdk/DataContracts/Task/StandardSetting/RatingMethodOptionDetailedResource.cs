using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting;

[DataContract(Name = ApiConsts.Contracts.RatingMethodOption, Namespace = "")]
public class RatingMethodOptionDetailedResource : RatingMethodDetailedResource
{
}