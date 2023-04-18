using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Result
{
    [DataContract(Name = ApiConsts.Contracts.Resource, Namespace = "")]
    public abstract class BaseResultResource : LinkedResource
    {
        [DataMember(Name = ApiConsts.Members.Centre)]
        public LinkedResource Centre { get; set; }

        [DataMember(Name = ApiConsts.Members.Candidate)]
        public LinkedResource Candidate { get; set; }

        [DataMember(Name = ApiConsts.Members.Mark)]
        public double Mark { get; set; }

        [DataMember(Name = ApiConsts.Members.AvailableMarks)]
        public int AvailableMarks { get; set; }

        [DataMember(Name = ApiConsts.Members.Grade)]
        public string Grade { get; set; }

        [DataMember(Name = ApiConsts.Members.StartedDate)]
        public DateTime? StartedDate { get; set; }

        [DataMember(Name = ApiConsts.Members.SubmittedDate)]
        public DateTime SubmittedDate { get; set; }

        [DataMember(Name = ApiConsts.Members.WarehousedDate)]
        public DateTime WarehousedDate { get; set; }
    }
}
