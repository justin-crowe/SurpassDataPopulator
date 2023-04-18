using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Result
{
    [DataContract(Name = ApiConsts.Members.MarkBreakdownItem, Namespace = "")]
    public class MarkBreakdownResource
    {
        [DataMember(Name = ApiConsts.Members.Name)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Mark)]
        public double Mark { get; set; }

        [DataMember(Name = ApiConsts.Members.AvailableMarks)]
        public double AvailableMarks { get; set; }
    }
}
