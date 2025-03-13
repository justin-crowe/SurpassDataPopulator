namespace SurpassApiSdk.UrlFormatters.Interfaces;

internal interface ISurpassTestFormUrlFormatter
{
    string Get();

    string GetForSectionId(int testFormId, int sectionId);

    string GetForSectionId(string testFormRef, int sectionId);

    string GetForId(int id, bool includeItems = false);

    string GetForRef(string reference, bool includeItems = false);
}