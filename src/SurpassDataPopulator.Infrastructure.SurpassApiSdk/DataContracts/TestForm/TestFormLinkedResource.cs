using System.Runtime.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestForm
{
    [ControllerName(ApiConsts.Segments.TestForm, 2)]
    [DataContract(Name = ApiConsts.Contracts.TestForm, Namespace = "")]
    public class TestFormLinkedResource : LinkedResource
    {
        [DataMember(Name = ApiConsts.Members.Status, Order = 4)]
        [NotSortable]
        [NotFilterable]
        public string Status { get; set; }

        [DataMember(Name = ApiConsts.Members.Valid, Order = 5)]
        [NotSortable]
        [NotFilterable]
        public bool Valid { get; set; }
    }
}
