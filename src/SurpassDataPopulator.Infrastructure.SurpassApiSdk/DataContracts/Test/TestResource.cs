using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Test
{
    [DataContract(Name = ApiConsts.Contracts.Test, Namespace = "")]
    [ControllerName(ApiConsts.Segments.Test, 2)]
    public class TestResource : LinkedResource
    {
    }
}
