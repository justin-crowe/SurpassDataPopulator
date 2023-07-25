using System.Collections.Generic;
using System.Linq;
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
                //if the requested name tag already exists, then override it with the new one
                var existingTag = item.Tags.FirstOrDefault(t => t.Name == requestedTag.Name);
                if (existingTag != null)
                {
                    item.Tags.Remove(existingTag);
                }
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