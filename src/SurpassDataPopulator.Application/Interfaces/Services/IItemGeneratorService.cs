using System.Threading.Tasks;
using SurpassDataPopulator.Domain.Data.Builders.Items;

namespace SurpassDataPopulator.Application.Interfaces.Services;

public interface IItemGeneratorService
{
    Task<ItemBuildResult> GenerateItemsAsync(ItemBuildRequest request);
}