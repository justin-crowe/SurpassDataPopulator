using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemTagValue;

public class SubjectTagValueResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 0, EmitDefaultValue = false)]
    public long Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Text, Order = 1, EmitDefaultValue = false)]
    public string Text { get; set; }

    [DataMember(Name = ApiConsts.Members.Number, Order = 2, EmitDefaultValue = false)]
    public decimal? Number { get; set; }
}