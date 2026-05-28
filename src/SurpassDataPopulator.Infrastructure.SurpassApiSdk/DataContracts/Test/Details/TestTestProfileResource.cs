using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Test.Details;

[DataContract(Name = ApiConsts.Contracts.Test, Namespace = "")]
public class TestTestProfileResource
{
    [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = true)]
    public int? Id { get; set; }
}