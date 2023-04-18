using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Result
{
    [DataContract(Name = ApiConsts.Contracts.SectionSelector, Namespace = "")]
    public class SectionSelectorResource
    {
        [DataMember(Name = ApiConsts.Members.Id)]
        public int Id { get; set; }

        [DataMember(Name = ApiConsts.Members.Name)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Description)]
        public string Description { get; set; }

        [DataMember(Name = ApiConsts.Members.Duration)]
        public int Duration { get; set; }

        [DataMember(Name = ApiConsts.Members.RequiredSections)]
        public int RequiredSections { get; set; }
    }
}
