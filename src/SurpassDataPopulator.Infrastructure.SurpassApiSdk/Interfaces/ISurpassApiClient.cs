using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.Interfaces;

public interface ISurpassApiClient
{
    SurpassApiLanguageKey Language { get; set; }

    SurpassApiMediaType MediaType { get; set; }

    IBasicPageResourceController BasicPage { get; }

    ICandidateResourceController Candidate { get; }

    ICentreResourceController Centre { get; }

    ICentreSubjectAssociationResourceController CentreSubjectAssociation { get; }

    IFolderResourceController Folder { get; }

    IItemSetResourceController ItemSet { get; }

    IItemResourceController Item { get; }

    IItemTagValueResourceController ItemTagValue { get; }

    IMediaResourceController Media { get; }

    IPermissionResourceController Permission { get; }

    IReportResourceController Reports { get; }

    IResultResourceController Result { get; }

    ISubjectResourceController Subject { get; }

    ISummaryResultResourceController SummaryResult { get; }

    ITagGroupResourceController TagGroup { get; }

    ITagValueResourceController TagValue { get; }

    ITestProfileResourceController TestProfile { get; }

    ITestScheduleResourceController TestSchedule { get; }

    ITestSessionResourceController TestSession { get; }

    ITokenCreateResourceController TokenCreate { get; }

    IUserResourceController User { get; }

    IUserRoleResourceController UserRole { get; }

    ITestResourceController Test { get; }

    ITaskResourceController Task { get; }

    IGeneralTaskResourceController GeneralTask { get; }

    IWorkflowStatusResourceController WorkflowStatus { get; }

    ITestFormResourceController TestForm { get; }

    bool ValidateSslCertificate { get; set; }
}