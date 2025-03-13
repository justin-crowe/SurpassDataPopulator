using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse;

[DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
public class ItemResponseUnsupportedQuestionTypeResource : ItemResponseBaseResource
{
}