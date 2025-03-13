using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Test;

[ControllerName(ApiConsts.Segments.Test, 2)]
[DataContract(Name = ApiConsts.Contracts.Test, Namespace = "")]
public class TestLinkedResource : LinkedResource
{
}