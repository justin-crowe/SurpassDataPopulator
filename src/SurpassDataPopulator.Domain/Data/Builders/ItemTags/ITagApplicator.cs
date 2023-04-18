using System.Collections.Generic;
using SurpassDataPopulator.Domain.Entities.Items;

namespace SurpassDataPopulator.Domain.Data.Builders.ItemTags
{
    public interface ITagApplicator
    {
        void Apply(Item item, ITagRequirements requestedTags);
        void Apply(List<Item> items, ITagRequirements requestedTags);
    }
}