using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.ItemList;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task
{
    [ControllerName(ApiConsts.Segments.ItemList, 2)]
    [DataContract(Name = ApiConsts.Contracts.ItemList, Namespace = "")]
    public class TaskItemListExtendedResource : ItemListResource
    {
        [DataMember(Name = ApiConsts.Members.Name, Order = 3)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.IsDeleted, Order = 4)]
        public bool IsDeleted { get; set; }
    }
}
