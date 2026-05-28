using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task;

[DataContract(Name = ApiConsts.Contracts.TaskProfileTagCollectionCriterion, Namespace = "")]
public class TaskProfileTagCollectionCriterionResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 1)]
    public long Id { get; set; }

    [DataMember(Name = ApiConsts.Members.SubjectReferences, Order = 2)]
    public ICollection<string> SubjectReferences { get; set; }

    [DataMember(Name = ApiConsts.Members.TagCollectionGroup, Order = 3)]
    public string TagCollectionGroup { get; set; }

    [DataMember(Name = ApiConsts.Members.TagCollections, Order = 4)]
    public ICollection<string> TagCollections { get; set; }

    [DataMember(Name = ApiConsts.Members.InverseTagCollectionSelection, Order = 5)]
    public bool InverseTagCollectionSelection { get; set; }
}