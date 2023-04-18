using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Result
{
    [DataContract(Name = ApiConsts.Contracts.LearningOutcome, Namespace = "")]
    public class LearningOutcomeResource
    {
        [DataMember(Name = ApiConsts.Members.Name)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Pass)]
        public bool Pass { get; set; }

        [DataMember(Name = ApiConsts.Members.Mark)]
        public double Mark { get; set; }

        [DataMember(Name = ApiConsts.Members.TotalMark)]
        public double TotalMark { get; set; }

        [DataMember(Name = ApiConsts.Members.PercentageMark)]
        public double PercentageMark { get; set; }

        [DataMember(Name = ApiConsts.Members.PassPercentage)]
        public double PassPercentage { get; set; }

        [DataMember(Name = ApiConsts.Members.ThresholdExceeded)]
        public bool ThresholdExceeded { get; set; }

        [DataMember(Name = ApiConsts.Members.DefaultPassMarkApplied)]
        public bool DefaultPassMarkApplied { get; set; }
    }
}
