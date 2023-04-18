using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Result
{
    [DataContract(Name = ApiConsts.Contracts.LearningOutcomeBoundary, Namespace = "")]
    public class LearningOutcomeBoundaryResource
    {
        [DataMember(Name = ApiConsts.Members.IsDefault)]
        public bool IsDefault { get; set; }

        [DataMember(Name = ApiConsts.Members.Text)]
        public string Text { get; set; }

        [DataMember(Name = ApiConsts.Members.PassPercentage)]
        public double PassPercentage { get; set; }
    }
}
