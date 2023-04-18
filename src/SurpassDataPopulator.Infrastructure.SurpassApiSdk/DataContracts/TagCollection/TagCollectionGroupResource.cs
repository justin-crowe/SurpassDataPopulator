using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TagCollection
{
    [DataContract(Name = ApiConsts.Contracts.TagCollectionGroup, Namespace = "")]
    [ControllerName(ApiConsts.Segments.TagCollectionGroup, 2)]
    public class TagCollectionGroupResource : Resource
    {
    }
}
