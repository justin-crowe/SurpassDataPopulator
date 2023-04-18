using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Country;
using SurpassApiSdk.DataContracts.County;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Centre
{
    [DataContract(Name = ApiConsts.Contracts.Centre, Namespace = "")]
    [ControllerName(ApiConsts.Segments.Centre, 2)]
    public class CentreDetailedResource : LinkedResource
    {
        /// <summary>
        /// Centre Name
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = false, Order = 3)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.RandomiseTestForms, EmitDefaultValue = true, Order = 4)]
        public bool? RandomiseTestForms { get; set; }

        [DataMember(Name = ApiConsts.Members.HideSubjectFromSubjectGroups, EmitDefaultValue = true, Order = 5)]
        public bool? HideSubjectFromSubjectGroups { get; set; }

        [DataMember(Name = ApiConsts.Members.ExcludeItemStatistics, EmitDefaultValue = true, Order = 6)]
        public bool ExcludeItemStatistics { get; set; }

        [DataMember(Name = ApiConsts.Members.AddressLine1, EmitDefaultValue = false, Order = 7)]
        [NotSortable]
        [NotFilterable]
        public string AddressLine1 { get; set; }

        [DataMember(Name = ApiConsts.Members.AddressLine2, EmitDefaultValue = false, Order = 8)]
        [NotSortable]
        [NotFilterable]
        public string AddressLine2 { get; set; }

        [DataMember(Name = ApiConsts.Members.Town, EmitDefaultValue = false, Order = 9)]
        [NotSortable]
        [NotFilterable]
        public string Town { get; set; }

        [DataMember(Name = ApiConsts.Members.County, EmitDefaultValue = false, Order = 10)]
        [NotSortable]
        [NotFilterable]
        public CountyLinkedResource County { get; set; }

        [DataMember(Name = ApiConsts.Members.PostCode, EmitDefaultValue = false, Order = 11)]
        [NotSortable]
        [NotFilterable]
        public string PostCode { get; set; }

        [DataMember(Name = ApiConsts.Members.Country, EmitDefaultValue = false, Order = 12)]
        [NotSortable]
        [NotFilterable]
        public CountryLinkedResource Country { get; set; }

        [DataMember(Name = ApiConsts.Members.Status, Order = 15)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CentreStatus Status { get; set; }
    }
}
