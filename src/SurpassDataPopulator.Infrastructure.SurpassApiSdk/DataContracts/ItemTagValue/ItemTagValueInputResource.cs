using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemTagValue
{
    /// <summary>
    /// Represents a base tag group properties
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.ItemTagValue, Namespace = "")]
    public class ItemTagValueInputResource
    {
        [DataMember(Name = ApiConsts.Members.Item, Order = 0, EmitDefaultValue = false)]
        public SubjectItemTagValueResource Item { get; set; }

        [DataMember(Name = ApiConsts.Members.TagValue, Order = 2, EmitDefaultValue = false)]
        public SubjectTagValueResource TagValue { get; set; }

        [DataMember(Name = ApiConsts.Members.TagGroup, Order = 3, EmitDefaultValue = false)]
        public TagGroupResource TagGroup { get; set; }

        [DataMember(Name = ApiConsts.Members.Mark, Order = 4, EmitDefaultValue = false)]
        public int? Mark { get; set; }

        [DataMember(Name = ApiConsts.Members.Collection, Order = 5, EmitDefaultValue = false)]
        public TagCollection.TagCollectionRootResource Collection { get; set; }
    }
}
