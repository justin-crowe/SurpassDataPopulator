using System.Collections.Generic;

namespace SurpassDataPopulator.Domain.Data.Builders.ItemTags
{
    public interface ITagRequirements
    {
        List<ITagRequest> Requirements { get; }
    }
}