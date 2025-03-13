using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.ItemResponse.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse;

[DataContract(Name = ApiConsts.Contracts.DropZone, Namespace = "")]
public class DropZoneResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 1, EmitDefaultValue = false)]
    public string Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Title, Order = 2, EmitDefaultValue = false)]
    public string Title { get; set; }

    [DataMember(Name = ApiConsts.Members.MaxOptions, Order = 3)]
    public int MaxOptions { get; set; }

    [DataMember(Name = ApiConsts.Members.CorrectDragOptions, Order = 4, EmitDefaultValue = false)]
    public IEnumerable<CorrectDragItemResource> CorrectDragOptions { get; set; }

    [DataMember(Name = ApiConsts.Members.CandidateResponse, Order = 5, EmitDefaultValue = false)]
    public IEnumerable<DragAndDropMatchResource> CandidateResponse { get; set; }
}