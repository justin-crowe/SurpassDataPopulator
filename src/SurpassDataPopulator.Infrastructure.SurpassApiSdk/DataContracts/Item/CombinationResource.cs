using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item;

public class CombinationResource
{
    [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = true)]
    public long Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Mark, EmitDefaultValue = true)]
    public int Mark { get; set; }

    [DataMember(Name = ApiConsts.Members.Title, EmitDefaultValue = true)]
    public string Title { get; set; }

    [DataMember(Name = ApiConsts.Members.Options, EmitDefaultValue = true)]
    public IEnumerable<CombinationOptionResource> Options { get; set; }
}