using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.ItemResponse;
using SurpassApiSdk.DataContracts.ItemResponse.Details;
using SurpassApiSdk.Helpers;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Result;

[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class ItemResource
{
    private string _candidateResponse;
    private string _itemComment;

    [DataMember(Name = ApiConsts.Members.Name)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Version)]
    public int Version { get; set; }

    [DataMember(Name = ApiConsts.Members.Mark)]
    public double Mark { get; set; }

    [DataMember(Name = ApiConsts.Members.AwardedMark)]
    public double AwardedMark { get; set; }

    [DataMember(Name = ApiConsts.Members.AvailableMarks)]
    public int AvailableMarks { get; set; }

    [DataMember(Name = ApiConsts.Members.ViewingTime)]
    public string ViewingTime { get; set; }

    [DataMember(Name = ApiConsts.Members.LearningOutcome)]
    public string LearningOutcome { get; set; }

    [DataMember(Name = ApiConsts.Members.MarkBreakdown)]
    public List<MarkBreakdownResource> MarkBreakdown { get; set; }

    [DataMember(Name = ApiConsts.Members.Unit)]
    public string Unit { get; set; }

    [DataMember(Name = ApiConsts.Members.SurpassReference)]
    public string SurpassReference { get; set; }

    [DataMember(Name = ApiConsts.Members.NonScored)]
    public bool NonScored { get; set; }

    [DataMember(Name = ApiConsts.Members.Type)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ResultItemType Type { get; set; }

    [DataMember(Name = ApiConsts.Members.Group, EmitDefaultValue = false)]
    public GroupResource Group { get; set; }

    [DataMember(Name = ApiConsts.Members.CandidateResponse, EmitDefaultValue = false)]
    public CDataWrapper CandidateResponse
    {
        get { return _candidateResponse; }
        set { _candidateResponse = value; }
    }

    [DataMember(Name = ApiConsts.Members.ItemComment, EmitDefaultValue = false)]
    public CDataWrapper ItemComment
    {
        get { return _itemComment; }
        set { _itemComment = value; }
    }

    [DataMember(Name = ApiConsts.Members.ItemResponse)]
    public ItemResponseDetailResource ItemResponse { get; set; }

    [DataMember(Name = ApiConsts.Members.Marker)]
    public string Marker { get; set; }

    [DataMember(Name = ApiConsts.Members.DisplayNumber)]
    public string DisplayNumber { get; set; }

    [DataMember(Name = ApiConsts.Members.MarkingType)]
    public string MarkingType { get; set; }

    [DataMember(Name = ApiConsts.Members.ItemSetId)]
    public string ItemSetId { get; set; }

    [DataMember(Name = ApiConsts.Members.ItemSetName)]
    public string ItemSetName { get; set; }
}