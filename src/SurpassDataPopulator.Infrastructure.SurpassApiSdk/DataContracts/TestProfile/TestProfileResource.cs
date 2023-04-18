using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestProfile
{
    [ControllerName(ApiConsts.Segments.TestProfile, 2)]
    [DataContract(Name = ApiConsts.Contracts.TestProfile, Namespace = "")]
    public class TestProfileResource : Resource
    {
    }
}
