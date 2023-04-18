using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting
{
    [DataContract(Name = ApiConsts.Contracts.StandardSettingItemList, Namespace = "")]
    public class StandardSettingItemListResource : Resource
    {
        [DataMember(Name = ApiConsts.Members.RefreshListContent, Order = 2)]
        public bool? RefreshListContent { get; set; }
    }
}
