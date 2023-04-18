using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details
{
    [DataContract(Name = ApiConsts.Contracts.AnswerList, Namespace = "")]
    public class ShortAnswerListResource
    {
        [DataMember(Name = ApiConsts.Members.Answers, EmitDefaultValue = true)]
        public IEnumerable<string> Answers { get; set; }
    }
}
