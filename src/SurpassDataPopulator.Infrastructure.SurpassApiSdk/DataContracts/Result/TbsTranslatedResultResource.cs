using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Result;

[DataContract(Name = ApiConsts.Contracts.Result, Namespace = "")]
[ControllerName(ApiConsts.Segments.Result, 2)]
public class TbsTranslatedResultResource
{
    [DataMember(Name = ApiConsts.Members.CandidateResponse, Order = 0)]
    public string CandidateResponse { get; set; }
}