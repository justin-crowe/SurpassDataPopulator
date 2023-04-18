using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.HistoricalResult;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.DataContracts.Test;
using SurpassApiSdk.DataContracts.TestForm;
using SurpassApiSdk.DataContracts.User;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.RescoringRules
{
    /// <summary>
    /// Represents a <see cref="RescoringRuleDetailedResource"/> to get single rule./>
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.RescoringRule, Namespace = "")]
    public class RescoringRuleDetailedResourceBase : LinkedResource
    {
        [DataMember(Name = ApiConsts.Members.User)]
        public UserResource User { get; set; }

        [DataMember(Name = ApiConsts.Members.Subject)]
        public SubjectLinkedResource Subject { get; set; }

        [DataMember(Name = ApiConsts.Members.Test)]
        public TestLinkedResource Test { get; set; }

        [DataMember(Name = ApiConsts.Members.TestForm)]
        public TestFormResource TestForm { get; set; }

        [DataMember(Name = ApiConsts.Members.StartDate)]
        public DateTime StartDate { get; set; }

        [DataMember(Name = ApiConsts.Members.EndDate)]
        public DateTime EndDate { get; set; }

        [DataMember(Name = ApiConsts.Members.SavedDate)]
        public DateTime SavedDate { get; set; }

        [DataMember(Name = ApiConsts.Members.HistoricalResults)]
        public List<HistoricalResultResource> HistoricalResults { get; set; }

        [DataMember(Name = ApiConsts.Members.ScoringData)]
        public List<ScoringDataResource> ScoringData { get; set; }
    }
}
