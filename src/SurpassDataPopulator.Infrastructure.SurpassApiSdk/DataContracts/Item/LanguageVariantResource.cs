using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item
{
    /// <summary>
    /// Language variant item resource
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.LanguageVariant, Namespace = "")]
    [ControllerName(ApiConsts.Segments.LanguageVariant, 2)]
    public class LanguageVariantResource : LanguageResource
    {
        [DataMember(Name = ApiConsts.Members.Href, EmitDefaultValue = true)]
        public string Href { get; set; }
    }
}
