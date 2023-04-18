using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item
{
    /// <summary>
    /// Item language code resource
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.Language, Namespace = "")]
    public class LanguageCodeResource
    {
        [DataMember(Name = ApiConsts.Members.Code, EmitDefaultValue = true)]
        public string Code { get; set; }
    }
}
