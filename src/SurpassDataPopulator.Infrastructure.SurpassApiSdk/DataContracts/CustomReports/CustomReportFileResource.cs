using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.CustomReports
{
    [DataContract(Name = ApiConsts.Contracts.CustomReportManagement, Namespace = "")]
    public class CustomReportFileResource
    {
        [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = true)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Content, EmitDefaultValue = true)]
        public byte[] Content { get; set; }

        public bool IsValidTemplate()
        {
            var isValid = Content != null && !string.IsNullOrEmpty(Name);
            if (!isValid)
            {
                return false;
            }

            var ext = Path.GetExtension(Name);
            isValid = CustomReportConstants.AllowedExtensions.Any(
                x => x.Equals(ext, StringComparison.OrdinalIgnoreCase));

            return isValid;
        }
    }
}
