using System.ComponentModel;
using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Centre;

/// <summary>
/// Represents a base centre properties
/// </summary>
[DataContract(Name = ApiConsts.Contracts.Centre, Namespace = "")]
public class CentreCreateResource
{
    [DataMember(Name = ApiConsts.Members.Name, Order = 0, EmitDefaultValue = false)]
    public string Name { get; set; }

    /// <summary>
    /// Resource Reference
    /// </summary>
    [DataMember(Name = ApiConsts.Members.Reference, Order = 1, EmitDefaultValue = false)]
    public string Reference { get; set; }

    [DataMember(Name = ApiConsts.Members.RandomiseTestForms, EmitDefaultValue = true)]
    [DefaultValue(true)]
    public bool? RandomiseTestForms { get; set; }

    [DataMember(Name = ApiConsts.Members.HideSubjectFromSubjectGroups, EmitDefaultValue = true)]
    [DefaultValue(false)]
    public bool? HideSubjectFromSubjectGroups { get; set; }

    [DataMember(Name = ApiConsts.Members.ExcludeItemStatistics, EmitDefaultValue = true)]
    [DefaultValue(false)]
    public bool? ExcludeItemStatistics { get; set; }

    [DataMember(Name = ApiConsts.Members.AddressLine1)]
    public string AddressLine1 { get; set; }

    [DataMember(Name = ApiConsts.Members.AddressLine2)]
    public string AddressLine2 { get; set; }

    [DataMember(Name = ApiConsts.Members.Town)]
    public string Town { get; set; }

    [DataMember(Name = ApiConsts.Members.County)]
    public IdResource County { get; set; }

    [DataMember(Name = ApiConsts.Members.PostCode)]
    public string PostCode { get; set; }

    [DataMember(Name = ApiConsts.Members.Country)]
    public IdResource Country { get; set; }
}