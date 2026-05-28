using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestSchedule;

[DataContract(Name = ApiConsts.Members.SelectedSections, Namespace = "")]
public class SelectedSectionsResource
{
    [DataMember(Name = ApiConsts.Members.SectionName, Order = 1)]
    public string SectionName { get; set; }

    [DataMember(Name = ApiConsts.Members.SectionOrder, Order = 2)]
    public int SectionOrder { get; set; }
}