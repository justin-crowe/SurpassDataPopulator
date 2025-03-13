using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestSession;

[DataContract(Namespace = "")]
public class TestSessionActivatedInfoResource
{
    [DataMember(Name = ApiConsts.Members.StartedDate, EmitDefaultValue = false)]
    public DateTime? StartedDate { get; set; }

    [DataMember(Name = ApiConsts.Members.SubmittedDate, EmitDefaultValue = false)]
    public DateTime? SubmittedDate { get; set; }

    [DataMember(Name = ApiConsts.Members.Started)]
    public bool Started { get; set; }
}