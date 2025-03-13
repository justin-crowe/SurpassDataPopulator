using System.Collections.Generic;
using System.Threading.Tasks;
using SurpassDataPopulator.Domain.Data.Builders.ItemTags;
using SurpassDataPopulator.Domain.Entities.Items;

namespace SurpassDataPopulator.Application.Interfaces.Services;

public interface ISurpassApiService
{
    public Task<bool> SubjectExistsAsync(string subjectRef);
    public Task CreateItemsAsync(List<Item> items, string subjectReference);
}