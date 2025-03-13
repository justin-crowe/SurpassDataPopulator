using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.MediaGroup;

[DataContract(Name = ApiConsts.Contracts.MediaGroup, Namespace = "")]
public class MediaGroupUpdateResource : BaseMediaGroupResource
{
}