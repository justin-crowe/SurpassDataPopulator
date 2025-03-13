using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item;

/// <summary>
/// Item language resource
/// </summary>
[DataContract(Name = ApiConsts.Contracts.Language, Namespace = "")]
public class LanguageResource : LanguageCodeResource
{
    [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = true)]
    public string Name { get; set; }
}