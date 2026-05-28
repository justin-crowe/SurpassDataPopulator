using SurpassApiSdk.DataContracts.CustomReports;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface ICustomReportGenerationResourceController
{
    CustomReportGenerateFilePostResponseModel GenerateFile(CustomReportGenerationInputResource resource);
}