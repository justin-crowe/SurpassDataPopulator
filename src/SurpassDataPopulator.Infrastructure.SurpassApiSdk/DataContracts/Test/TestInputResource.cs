using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Test;

/// <summary>
/// Represents a base test properties
/// </summary>
[DataContract(Name = ApiConsts.Contracts.Test, Namespace = "")]
public class TestInputResource : BaseTestResource
{
    [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = false)]
    public ItemSubjectResource Subject { get; set; }
}