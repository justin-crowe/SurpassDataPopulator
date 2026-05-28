using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestSession;

[DataContract(Name = ApiConsts.Contracts.TestSession, Namespace = "")]
[ControllerName(ApiConsts.Segments.TestSession, 2)]
public class TestSessionFileDetailedResource : LinkedResource
{
    [DataMember(Name = ApiConsts.Members.TestSessionId, Order = 3)]
    public int TestSessionId { get; set; }

    [DataMember(Name = ApiConsts.Members.TestSessionName, Order = 4)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.TestSessionDescription, Order = 5)]
    public string Description { get; set; }

    [DataMember(Name = ApiConsts.Members.TestSessionData, Order = 6)]
    public string Data { get; set; }
}