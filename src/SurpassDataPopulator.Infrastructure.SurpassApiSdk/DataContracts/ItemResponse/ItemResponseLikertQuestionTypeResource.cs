using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.ItemResponse.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse
{
    [DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
    public class ItemResponseLikertQuestionTypeResource : ItemResponseBaseResource
    {
        [DataMember(Name = ApiConsts.Members.Options, EmitDefaultValue = false, Order = 10)]
        public List<ItemResponseLikertOption> Options { get; set; }

        [DataMember(Name = ApiConsts.Members.Statements, EmitDefaultValue = false, Order = 11)]
        public List<ItemResponseLikertStatement> Statements { get; set; }

        [DataMember(Name = ApiConsts.Members.Selections, EmitDefaultValue = false, Order = 12)]
        public List<ItemResponseLikertSelection> Selections { get; set; }
    }
}
