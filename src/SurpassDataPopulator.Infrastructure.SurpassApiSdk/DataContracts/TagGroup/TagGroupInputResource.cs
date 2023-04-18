using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TagGroup
{
    /// <summary>
    /// Represents a base tag group properties
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.TagGroup, Namespace = "")]
    public class TagGroupInputResource : TagGroupBaseResource
    {
        [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = true)]
        public ItemSubjectResource Subject { get; set; }
    }
}
