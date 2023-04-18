using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestProfile.Details
{
    [DataContract(Name = ApiConsts.Contracts.TestProfile, Namespace = "")]
    public class TestProfileScoreReportResource
    {
        [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = true)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.ScoreReportHtml, EmitDefaultValue = true)]
        public string ScoreReport { get; set; }
    }
}
