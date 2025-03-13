using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TagCategory;

[DataContract(Name = ApiConsts.Contracts.TagCategory, Namespace = "")]
[ControllerName(ApiConsts.Segments.TagCategory, 2)]
public class TagCategoryResource : LinkedIdResource
{
}