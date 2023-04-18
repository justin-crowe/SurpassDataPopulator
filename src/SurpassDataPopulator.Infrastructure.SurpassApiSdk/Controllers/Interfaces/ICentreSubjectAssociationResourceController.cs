using SurpassApiSdk.DataContracts.CentreSubjectAssociation;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface ICentreSubjectAssociationResourceController
    {
        TimeZonePostResponseModel Delete(long id);

        TimeZonePageResponse<CentreSubjectAssociationDetailedResource> Get(long id);

        TimeZonePageResponse<CentreSubjectAssociationResource> Get(string queryString = null);

        TimeZonePostResponseModel Post(CentreSubjectAssociationCreateResource centreSubjectAssociation);

        TimeZonePostResponseModel Put(long id, CentreSubjectAssociationUpdateResource centreSubjectAssociation);
    }
}
