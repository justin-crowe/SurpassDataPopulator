using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.TagGroup;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TagValue
{
    [DataContract(Name = ApiConsts.Contracts.TagValue, Namespace = "")]
    [ControllerName(ApiConsts.Segments.TagValue, 2)]
    public class TagValueResource : LinkedResource
    {
        /// <summary>
        /// Tag Value Name
        /// </summary>
        [DataMember(Name = ApiConsts.Members.TagValue, EmitDefaultValue = false)]
        public string TagValue { get; set; }

        [DataMember(Name = ApiConsts.Members.TagGroup)]
        public TagGroupResource TagGroup { get; set; }

        [DataMember(Name = ApiConsts.Members.Deleted, EmitDefaultValue = false)]
        public bool Deleted { get; set; }
    }
}
