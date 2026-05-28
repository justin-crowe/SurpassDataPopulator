using System.Collections.Generic;

namespace SurpassDataPopulator.Domain.Data.Builders.ItemTags.General;

public class GeneralTagRequirement : ITagRequirements
{
    public GeneralTagRequirement(ITagRequest request)
    {
        Requirements = new List<ITagRequest> {request};
    }

    public string Type => "General";
    public List<ITagRequest> Requirements { get; }
}