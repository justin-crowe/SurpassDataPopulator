using System.Runtime.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.DataContracts.Base.Interfaces;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting
{
    [ControllerName(ApiConsts.Segments.StandardSettingResult, 2)]
    [DataContract(Name = ApiConsts.Contracts.StandardSettingResult, Namespace = "")]
    public class StandardSettingResultResource : ILinkedIdResource
    {
        [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
        public long? Id { get; set; }

        [DataMember(Name = ApiConsts.Members.Href, Order = 1)]
        [NotSortable]
        [NotFilterable]
        public string Href { get; set; }
    }
}
