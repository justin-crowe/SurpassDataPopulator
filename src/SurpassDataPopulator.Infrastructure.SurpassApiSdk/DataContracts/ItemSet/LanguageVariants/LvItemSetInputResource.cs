using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ItemSet.LanguageVariants;

[HasHiddenProperties]
[DataContract(Name = ApiConsts.Contracts.ItemSetLanguageVariant, Namespace = "")]
[ControllerName(ApiConsts.Segments.LanguageVariant, 2)]
public class LvItemSetInputResource : ItemSetInputResource
{
}