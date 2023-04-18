using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Subject
{
    [ControllerName(ApiConsts.Segments.Subject, 2)]
    [DataContract(Name = ApiConsts.Contracts.Subject, Namespace = "")]
    public class SubjectResource : Resource
    {
    }
}
