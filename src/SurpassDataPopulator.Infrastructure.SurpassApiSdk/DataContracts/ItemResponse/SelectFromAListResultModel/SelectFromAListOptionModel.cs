using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.SelectFromAListResultModel
{
    [DataContract]
    public class SelectFromAListOptionModel
    {
        [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = false, Order = 1)]
        public int Id { get; set; }

        [DataMember(Name = ApiConsts.Members.Text, EmitDefaultValue = false, Order = 2)]
        public string Text { get; set; }

        [DataMember(Name = ApiConsts.Members.Correct, Order = 3)]
        public bool IsCorrect { get; set; }

        [DataMember(Name = ApiConsts.Members.Selected, Order = 4)]
        public bool IsSelected { get; set; }
    }
}
