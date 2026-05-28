using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.HistoricalResult;

[DataContract(Name = ApiConsts.Contracts.HistoricalResult, Namespace = "")]
[ControllerName(ApiConsts.Segments.HistoricalResult, 2)]
public class HistoricalResultResource : LinkedResource
{
}