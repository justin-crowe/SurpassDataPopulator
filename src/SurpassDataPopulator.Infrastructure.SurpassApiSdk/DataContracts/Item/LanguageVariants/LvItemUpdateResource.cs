using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.LanguageVariants;

[HasHiddenProperties]
[DataContract(Name = ApiConsts.Contracts.ItemLanguageVariant, Namespace = "")]
[ControllerName(ApiConsts.Segments.LanguageVariant, 2)]
public class LvItemUpdateResource : ItemUpdateResource
{
}