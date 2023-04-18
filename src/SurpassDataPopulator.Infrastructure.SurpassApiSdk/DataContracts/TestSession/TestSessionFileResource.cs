using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestSession
{
    [DataContract(Name = ApiConsts.Contracts.TestSessionFile, Namespace = "")]
    [ControllerName(ApiConsts.Segments.TestSessionFile, 2)]
    public class TestSessionFileResource : LinkedResource
    {
    }
}
