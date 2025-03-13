using System.Collections.Generic;
using MediatR;
using SurpassDataPopulator.Application.DataPopulation.Items;

namespace SurpassDataPopulator.Application.DataPopulation.Adaptive;

public class CreateAdaptiveData : CreateItemData, IRequest
{
    public IEnumerable<string> LanguageVariants { get; set; }
}