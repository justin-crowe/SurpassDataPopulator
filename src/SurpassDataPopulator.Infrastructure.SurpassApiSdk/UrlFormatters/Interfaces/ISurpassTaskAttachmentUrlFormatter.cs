namespace SurpassApiSdk.UrlFormatters.Interfaces;

internal interface ISurpassTaskAttachmentUrlFormatter
{
    string GetForTaskId(long taskId);

    string GetForTaskAttachmentId(long taskId, long id);
}