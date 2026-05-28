using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details;

/// <summary>
/// Model that represents attached files of file attach question item in API
/// </summary>
[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class FileAttachItemFileResource
{
    [DataMember(Name = ApiConsts.Members.Title, EmitDefaultValue = true)]
    public string Title { get; set; }

    [DataMember(Name = ApiConsts.Members.AttachedFileType, EmitDefaultValue = true)]
    public string AttachedFileType { get; set; }

    [DataMember(Name = ApiConsts.Members.IsSecureDoc, EmitDefaultValue = true)]
    public bool IsSecureDoc { get; set; }

    [DataMember(Name = ApiConsts.Members.UploadLabel, EmitDefaultValue = true)]
    public string UploadLabel { get; set; }

    [DataMember(Name = ApiConsts.Members.AttachmentType, EmitDefaultValue = true)]
    public string AttachmentType { get; set; }

    [DataMember(Name = ApiConsts.Members.AttachedFileName, EmitDefaultValue = true)]
    public string AttachedFileName { get; set; }

    [DataMember(Name = ApiConsts.Members.AttachedFileData, EmitDefaultValue = true)]
    public string AttachedFileData { get; set; }
}