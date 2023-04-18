using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TagCategory
{
    [ControllerName(ApiConsts.Segments.TagGroup, 2)]
    [DataContract(Name = ApiConsts.Contracts.TagCategory, Namespace = "")]
    public class TagCategoryIdResource : IdResource
    {
    }
}
