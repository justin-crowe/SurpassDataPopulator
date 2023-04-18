using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestProfile.Details
{
    [DataContract(Name = ApiConsts.Contracts.TestProfile, Namespace = "")]
    public class TestProfileColorsResource
    {
        [DataMember(Name = ApiConsts.Members.ColourBackground, EmitDefaultValue = true)]
        public string ColourBackground { get; set; }

        [DataMember(Name = ApiConsts.Members.ColourText, EmitDefaultValue = true)]
        public string ColourText { get; set; }
    }
}
