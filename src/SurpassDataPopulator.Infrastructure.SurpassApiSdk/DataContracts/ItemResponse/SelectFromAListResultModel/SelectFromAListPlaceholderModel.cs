using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.SelectFromAListResultModel
{
    [DataContract]
    public class SelectFromAListPlaceholderModel
    {
        [DataMember(Name = ApiConsts.Members.Options, EmitDefaultValue = false, Order = 1)]
        public List<SelectFromAListOptionModel> PlaceholderOptions { get; set; }

        [DataMember(Name = ApiConsts.Members.UserMark, Order = 2)]
        public decimal UserMark { get; set; }

        [DataMember(Name = ApiConsts.Members.Id, Order = 3)]
        public string Id { get; set; }

        [DataMember(Name = ApiConsts.Members.Attempted, Order = 4)]
        public bool Attempted { get; set; }
    }
}
