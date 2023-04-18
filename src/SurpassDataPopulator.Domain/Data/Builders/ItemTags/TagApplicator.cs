using System.Collections.Generic;
using System.Threading.Tasks;
using SurpassDataPopulator.Domain.Entities.Items;

namespace SurpassDataPopulator.Domain.Data.Builders.ItemTags
{
    public class TagApplicator : ITagApplicator
    {
        public void Apply(Item item, ITagRequirements requestedTags)
        {
            foreach (var requestedTag in requestedTags.Requirements)
            {
                item.Tags.Add(requestedTag.Build(item));
            }
        }
        
        public void Apply(List<Item> items, ITagRequirements requestedTags)
        {
            Parallel.ForEach(items, item =>
            {
                Apply(item, requestedTags);
            });
        }
    }
}