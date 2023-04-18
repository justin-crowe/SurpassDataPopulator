using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Subject
{
    public class SubjectWithNameTagReferenceRolesCountResource : SubjectWithNameTagResource
    {
        /// <summary>
        /// Count of assigned roles
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Counter)]
        public int RolesCount { get; set; }
    }
}
