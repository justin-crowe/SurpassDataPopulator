using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.User;

[DataContract(Name = ApiConsts.Contracts.User, Namespace = "")]
public class UserCreateResource : UserUpdateResource
{
    [DataMember(Name = ApiConsts.Members.Reference, Order = 0)]
    public string Reference { get; set; }
}