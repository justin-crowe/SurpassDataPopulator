using System.Collections.Generic;

namespace SurpassDataPopulator.Domain.Data.Builders.ItemTags
{
    public interface ITagRequirements
    {
        string Type { get; }
        List<ITagRequest> Requirements { get; }
    }
}