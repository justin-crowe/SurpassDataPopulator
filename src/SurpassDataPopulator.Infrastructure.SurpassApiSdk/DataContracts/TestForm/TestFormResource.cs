using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestForm;

[DataContract(Name = ApiConsts.Contracts.TestForm, Namespace = "")]
[ControllerName(ApiConsts.Segments.TestForm, 2)]
public class TestFormResource : LinkedResource
{
}