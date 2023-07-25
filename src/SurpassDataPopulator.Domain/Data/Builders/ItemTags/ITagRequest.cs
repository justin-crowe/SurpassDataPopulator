using SurpassDataPopulator.Domain.Entities.Items;
using SurpassDataPopulator.Domain.Entities.Tags;

namespace SurpassDataPopulator.Domain.Data.Builders.ItemTags
{
    public interface ITagRequest
    {
        string Name { get; }
        Tag Build(Item context);
    }
}