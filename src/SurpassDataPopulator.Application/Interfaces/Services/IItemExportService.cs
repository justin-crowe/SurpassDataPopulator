using System.Collections.Generic;
using System.Threading.Tasks;
using SurpassDataPopulator.Domain.Entities.Items;

namespace SurpassDataPopulator.Application.Interfaces.Services
{
    public interface IItemExportService
    {
        Task ExportItemsAsync(List<Item> items, string subjectReference);
    }
}