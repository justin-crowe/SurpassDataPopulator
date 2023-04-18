using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.RescoringRules
{
    /// <summary>
    /// Represents a <see cref="RescoringRuleResource"/> to get many rules./>
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.RescoringRule, Namespace = "")]
    [ControllerName(ApiConsts.Segments.RescoringRule, 2)]
    public class RescoringRuleResource : LinkedResource
    {
    }
}
