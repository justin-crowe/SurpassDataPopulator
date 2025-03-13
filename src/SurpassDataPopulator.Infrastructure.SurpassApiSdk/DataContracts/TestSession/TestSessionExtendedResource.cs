using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.DataContracts.TestSession;

[DataContract(Name = ApiConsts.Contracts.TestSession, Namespace = "")]
[ControllerName(ApiConsts.Segments.TestSession, 2)]
public class TestSessionExtendedResource : TestSessionResource
{
    [DataMember(Name = ApiConsts.Members.Candidate, EmitDefaultValue = false, Order = 5)]
    public LinkedResource Candidate { get; set; }

    [DataMember(Name = ApiConsts.Members.Centre, EmitDefaultValue = false, Order = 6)]
    public LinkedResource Centre { get; set; }

    [DataMember(Name = ApiConsts.Members.CurrentExamState, EmitDefaultValue = false, Order = 7)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SurpassApiExamState ExamState { get; set; }

    [DataMember(Name = ApiConsts.Members.DownloadedToSecureClient, EmitDefaultValue = true, Order = 8)]
    public bool DownloadedToSecureClient { get; set; }
}