using System.ComponentModel;
using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestSession
{
    /// <summary>
    /// Represents properties for upload response
    /// </summary>
    [DataContract]
    public class TestSessionItemResponseResource
    {
        /// <summary>
        /// Question Number
        /// </summary>
        [DefaultValue("string")]
        [DataMember(Name = ApiConsts.Members.QuestionNumber, Order = 1)]
        public string QuestionNumber { get; set; }

        /// <summary>
        /// Answer
        /// </summary>
        [DefaultValue("string")]
        [DataMember(Name = ApiConsts.Members.Answer, Order = 2)]
        public string Answer { get; set; }
    }
}
