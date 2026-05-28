using System.Collections.Generic;
using MediatR;

namespace SurpassDataPopulator.Application.DataPopulation.Items.Adaptive;

public class CreateAdaptiveItemsCommand : CreateItemDataBase, IRequest<CreateAdaptiveItemsCommandResult>
{
    public IEnumerable<string> LanguageVariants { get; set; }
}