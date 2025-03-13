using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Result;

[DataContract(Name = ApiConsts.Contracts.ItemTagValue, Namespace = "")]
public class TbsTranslatedInputResultResource
{
    [DataMember(Name = ApiConsts.Members.CandidateResponse, Order = 0, EmitDefaultValue = false)]
    public string CandidateResponse { get; set; }

    [DataMember(Name = ApiConsts.Members.Tbs.Ids, Order = 1, EmitDefaultValue = false)]
    public string[] TbsIds { get; set; }
}