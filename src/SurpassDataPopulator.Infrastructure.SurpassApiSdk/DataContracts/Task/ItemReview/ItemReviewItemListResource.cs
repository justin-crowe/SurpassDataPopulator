using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.ItemReview
{
    [DataContract(Name = ApiConsts.Contracts.ItemReviewItemList, Namespace = "")]
    public class ItemReviewItemListResource : Resource
    {
        [DataMember(Name = ApiConsts.Members.RefreshListContent, Order = 2)]
        public bool? RefreshListContent { get; set; }
    }
}
