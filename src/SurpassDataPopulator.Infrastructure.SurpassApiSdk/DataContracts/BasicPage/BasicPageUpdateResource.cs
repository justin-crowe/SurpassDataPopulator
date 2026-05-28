using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.BasicPage;

[DataContract(Name = ApiConsts.Contracts.BasicPage, Namespace = "")]
public class BasicPageUpdateResource : BasePageResource
{
}