using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Folder;

[ControllerName(ApiConsts.Segments.Folder, 2)]
[DataContract(Name = ApiConsts.Contracts.Folder, Namespace = "")]
public class FolderLinkedResource : LinkedResource
{
}