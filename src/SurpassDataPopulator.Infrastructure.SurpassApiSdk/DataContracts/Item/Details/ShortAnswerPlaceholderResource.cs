using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details
{
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class ShortAnswerPlaceholderResource
    {
        [DataMember(Name = ApiConsts.Members.MaxCharacterCount, EmitDefaultValue = true)]
        public int? MaxCharacterCount { get; set; }

        [DataMember(Name = ApiConsts.Members.PlaceholderOptions, EmitDefaultValue = true)]
        public IEnumerable<string> PlaceholderOptions { get; set; }
    }
}
