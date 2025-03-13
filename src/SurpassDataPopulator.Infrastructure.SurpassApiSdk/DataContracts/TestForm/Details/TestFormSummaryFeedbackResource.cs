using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.TestForm.Enums;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestForm.Details;

[ControllerName(ApiConsts.Segments.TestForm, 2)]
[DataContract(Name = ApiConsts.Contracts.TestFeedbackSummaryFeedback, Namespace = "")]
public class TestFormSummaryFeedbackResource
{
    [DataMember(Name = ApiConsts.Members.Type, EmitDefaultValue = true, Order = 1)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SummaryFeedbackType Type { get; set; }

    [DataMember(Name = ApiConsts.Members.ReviewAnswers, EmitDefaultValue = true, Order = 2)]
    public bool ReviewAnswers { get; set; }

    [DataMember(Name = ApiConsts.Members.PrintableSummary, EmitDefaultValue = true, Order = 3)]
    public bool PrintableSummary { get; set; }

    [DataMember(Name = ApiConsts.Members.ShowCandidateDetails, EmitDefaultValue = true, Order = 4)]
    public bool ShowCandidateDetails { get; set; }

    [DataMember(Name = ApiConsts.Members.DisplayFeedbackByLearningOutcome, EmitDefaultValue = true, Order = 5)]
    public bool DisplayFeedbackByLearningOutcome { get; set; }

    [DataMember(Name = ApiConsts.Members.ShowViewFeedbackButton, EmitDefaultValue = true, Order = 6)]
    public bool ShowViewFeedbackButton { get; set; }
}