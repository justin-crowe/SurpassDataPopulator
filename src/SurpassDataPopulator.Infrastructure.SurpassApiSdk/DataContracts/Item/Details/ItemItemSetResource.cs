using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details;

[DataContract(Name = ApiConsts.Contracts.ItemSet, Namespace = "")]
public class ItemItemSetResource : ItemFolderResource
{
}