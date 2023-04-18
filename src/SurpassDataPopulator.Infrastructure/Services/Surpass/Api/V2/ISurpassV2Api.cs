using System.Threading.Tasks;
using Refit;
using SurpassApiSdk.DataContracts.Folder;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.DataContracts.ItemTagValue;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.DataContracts.TagGroup;
using SurpassApiSdk.DataContracts.TagValue;
using TagGroupResource = SurpassApiSdk.DataContracts.TagGroup.TagGroupResource;

namespace SurpassDataPopulator.Infrastructure.Services.Surpass.Api.V2
{
    public interface ISurpassV2Api
    {
        [Get("/Subject?reference={reference}")]
        Task<TimeZonePageResponse<SubjectDetailedResource>> SubjectSearch(string reference);
        
        
        
        [Get("/TagGroup?$filter=contains(name,{name}) and Subject/Reference eq {subjectReference}")]
        Task<TimeZonePageResponse<TagGroupResource>> TagGroupSearch(string name, string subjectReference);
        
        [Post("/TagGroup")]
        Task<PostResponseModel> TagGroup([Body] TagGroupInputResource tagGroup);
        
        
        
        [Get("/TagValue?$filter=Subject/Reference eq {subjectReference}")]
        Task<TimeZonePageResponse<TagValueManyResource>> TagValuesInSubject(string subjectReference);

        [Post("/TagValue")]
        Task<PostResponseModel> TagValue([Body] TagValueInputResource tagValue);
        
        
        [Post("/ItemTagValue")]
        Task<PostResponseModel> ItemTagValue([Body] ItemTagValueInputResource itemTagValue);
        

        [Get("/Folder?$filter=Subject/Reference eq {subjectReference}")]
        Task<TimeZonePageResponse<FolderResource>> FolderSearch(string subjectReference);
        
        [Post("/Folder")]
        Task<PostResponseModel> Folder([Body] FolderInputResource folder);
        
        [Post("/Item")]
        Task<PostResponseModel> Item([Body] ItemInputResource item);
    }
}