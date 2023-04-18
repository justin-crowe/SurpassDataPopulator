using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details.Items
{
    /// <summary>
    /// Model that represents file attach question item in API
    /// </summary>
    [CollectionSize(1)]
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class FileAttachItemUpdateResource
    {
        [DataMember(Name = ApiConsts.Members.IsManualMode, EmitDefaultValue = true)]
        public bool? IsManualMode { get; set; }

        [DataMember(Name = ApiConsts.Members.DownloadWording, EmitDefaultValue = true)]
        public string DownloadWording { get; set; }

        [DataMember(Name = ApiConsts.Members.UploadWording, EmitDefaultValue = true)]
        public string UploadWording { get; set; }

        [DataMember(Name = ApiConsts.Members.ChooseFileButtonWording, EmitDefaultValue = true)]
        public string ChooseFileButtonWording { get; set; }

        [DataMember(Name = ApiConsts.Members.AllowedExtensions, EmitDefaultValue = true)]
        public string AllowedExtensions { get; set; }

        [DataMember(Name = ApiConsts.Members.Files, EmitDefaultValue = true)]
        public IEnumerable<FileAttachItemFileResource> Files { get; set; }

        [DataMember(Name = ApiConsts.Members.MinimumNumberOfFiles, EmitDefaultValue = true)]
        public int? MinFilesCount { get; set; }

        [DataMember(Name = ApiConsts.Members.MaximumNumberOfFiles, EmitDefaultValue = true)]
        public int? MaxFilesCount { get; set; }

        [DataMember(Name = ApiConsts.Members.MaximumFileSize, EmitDefaultValue = true)]
        public int? MaxFileSize { get; set; }
    }
}
