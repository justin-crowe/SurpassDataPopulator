using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Test.Details;

[DataContract(Name = ApiConsts.Contracts.Test, Namespace = "")]
public class TestNdaResource
{
    [DataMember(Name = ApiConsts.Members.Required, EmitDefaultValue = true)]
    public bool? Required { get; set; }

    [DataMember(Name = ApiConsts.Members.Duration, EmitDefaultValue = true)]
    public int? Duration { get; set; }

    [DataMember(Name = ApiConsts.Members.ConfirmationText, EmitDefaultValue = true)]
    public string ConfirmationText { get; set; }
}