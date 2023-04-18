using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.ItemTagValue;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details.Items.Tbs
{
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class TbsMeasurementOpportunityResource
    {
        [DataMember(Name = ApiConsts.Members.Tbs.MeasurementOpportunityId)]
        public string MeasurementOpportunityId { get; set; }

        [DataMember(Name = ApiConsts.Members.Name)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.WeightedMark)]
        public short Mark { get; set; }

        [DataMember(Name = ApiConsts.Members.SubjectItemTagValues)]
        public IEnumerable<SubjectItemTagValueResource> SubjectTagValues { get; set; }
    }
}
