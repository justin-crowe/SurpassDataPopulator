using System.Globalization;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters;

internal class SurpassTaskAttachmentUrlFormatter : SurpassApiUrlFormatter, ISurpassTaskAttachmentUrlFormatter
{
    public SurpassTaskAttachmentUrlFormatter(string template)
        : base(template)
    {
    }

    public string GetForTaskId(long taskId)
    {
        return string.Format(CultureInfo.InvariantCulture, Template, taskId, string.Empty);
    }

    public string GetForTaskAttachmentId(long taskId, long id)
    {
        return string.Format(CultureInfo.InvariantCulture, Template, taskId, id);
    }
}