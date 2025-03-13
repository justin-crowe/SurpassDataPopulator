using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.RescoringRules;

[DataContract(Name = ApiConsts.Members.GradeBoundaries, Namespace = "")]
public class GradeBoundaries
{
    [DataMember(Name = ApiConsts.Members.MinRawScore)]
    public decimal MinRawScore { get; set; }

    [DataMember(Name = ApiConsts.Members.Grade)]
    public string Grade { get; set; }
}