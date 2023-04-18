using System.Runtime.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.DataContracts.Base.Interfaces;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Base
{
    [DataContract(Name = ApiConsts.Contracts.Resource, Namespace = "")]
    public class NameReferenceIdLinkedResource : NameReferenceResource, ILinkedIdResource
    {
        [DataMember(Name = ApiConsts.Members.Id, Order = 4)]
        public long? Id { get; set; }

        [DataMember(Name = ApiConsts.Members.Href, Order = 5)]
        [NotSortable]
        [NotFilterable]
        public string Href { get; set; }
    }
}
