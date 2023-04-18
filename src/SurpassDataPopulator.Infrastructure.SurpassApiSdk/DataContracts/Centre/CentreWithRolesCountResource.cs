using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Centre
{
    public class CentreWithRolesCountResource : CentreWithNameResource
    {
        /// <summary>
        /// Count of assigned roles
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Counter)]
        public int RolesCount { get; set; }
    }
}
