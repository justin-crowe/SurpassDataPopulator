using SurpassDataPopulator.Domain.Entities.Items;
using SurpassDataPopulator.Domain.Entities.Tags;

namespace SurpassDataPopulator.Domain.Data.Builders.ItemTags
{
    public interface ITagRequest
    {
        Tag Build(Item context);
    }
}