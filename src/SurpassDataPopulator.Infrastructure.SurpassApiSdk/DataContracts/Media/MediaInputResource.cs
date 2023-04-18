using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Media
{
    [DataContract(Name = ApiConsts.Contracts.Media, Namespace = "")]
    public class MediaInputResource : MediaBaseResource
    {
        [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = false)]
        public ItemSubjectResource Subject { get; set; }

        [DataMember(Name = ApiConsts.Members.SharedResource, EmitDefaultValue = true)]
        public bool SharedResource { get; set; }

        [DataMember(Name = ApiConsts.Members.HtmlString, EmitDefaultValue = true)]
        public string HtmlString { get; set; }
    }
}
