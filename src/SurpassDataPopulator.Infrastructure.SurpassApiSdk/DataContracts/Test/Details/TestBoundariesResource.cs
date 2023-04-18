using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Test.Details
{
    [DataContract(Name = ApiConsts.Contracts.Test, Namespace = "")]
    public class TestBoundariesResource
    {
        [DataMember(Name = ApiConsts.Members.Modifer, EmitDefaultValue = true)]
        public string Modifer { get; set; }

        [DataMember(Name = ApiConsts.Members.Value, EmitDefaultValue = true)]
        public int? Value { get; set; }

        [DataMember(Name = ApiConsts.Members.Description, EmitDefaultValue = true)]
        public string Description { get; set; }

        [DataMember(Name = ApiConsts.Members.HigherBoundary, EmitDefaultValue = true)]
        public bool? HigherBoundary { get; set; }
    }
}
