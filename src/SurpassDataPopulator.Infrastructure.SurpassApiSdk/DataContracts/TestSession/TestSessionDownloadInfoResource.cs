using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestSession
{
    [DataContract(Name = ApiConsts.Contracts.DownloadInfo, Namespace = "")]
    public class TestSessionDownloadInfoResource
    {
        [DataMember(Name = ApiConsts.Members.OS, Order = 1)]
        public string Os { get; set; }

        [DataMember(Name = ApiConsts.Members.IPAddress, Order = 2)]
        public string IpAddress { get; set; }

        [DataMember(Name = ApiConsts.Members.MachineName, Order = 3)]
        public string MachineName { get; set; }

        [DataMember(Name = ApiConsts.Members.DateTime, Order = 4)]
        public string DateTime { get; set; }

        [DataMember(Name = ApiConsts.Members.Local, Order = 5)]
        public bool Local { get; set; }

        [DataMember(Name = ApiConsts.Members.UserName, Order = 6)]
        public string UserName { get; set; }
    }
}
