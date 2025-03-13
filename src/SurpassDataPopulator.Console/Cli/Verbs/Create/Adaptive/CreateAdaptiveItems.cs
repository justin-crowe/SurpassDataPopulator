using System.Collections.Generic;
using CommandLine;
using SurpassDataPopulator.Console.Cli.Verbs.Create.Items;

namespace SurpassDataPopulator.Console.Cli.Verbs.Create.Adaptive;

[Verb("createAdaptiveItems", HelpText = "Add items to a subject to be used in adaptive tests.")]
public class CreateAdaptiveItems : CreateItems
{
    [Option('v', "variants", Required = false,
        HelpText = "List of language codes required for variants, this will create copies of items for each variants and link them. Then also add the relevant Adaptive tagging. Note that this is different to the Language Variants feature in Surpass")]
    public IEnumerable<string> LanguageVariants { get; set; }

       
}