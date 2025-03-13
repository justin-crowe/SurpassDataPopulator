using System.ComponentModel;
using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestSession;

[DataContract]
public class TestSessionMarkingInfo
{
    [DefaultValue("string")]
    [DataMember(Name = ApiConsts.Members.QuestionNumber, Order = 1)]
    public string QuestionNumber { get; set; }

    [DataMember(Name = ApiConsts.Members.Mark, Order = 3)]
    public int? Mark { get; set; }
}