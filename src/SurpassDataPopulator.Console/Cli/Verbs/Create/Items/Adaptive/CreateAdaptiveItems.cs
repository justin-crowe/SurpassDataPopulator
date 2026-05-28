using System.Collections.Generic;
using System.CommandLine;
using SurpassDataPopulator.Application.DataPopulation.Items;
using SurpassDataPopulator.Application.DataPopulation.Items.Adaptive;
using SurpassDataPopulator.Console.Display.Mappers;

namespace SurpassDataPopulator.Console.Cli.Verbs.Create.Items.Adaptive;

public sealed class CreateAdaptiveItems : CreateItems
{
    public Option<IEnumerable<string>> VariantsOption { get; set; }

    public CreateAdaptiveItems(
        ProgressAwareMediatrBinder mediatorBinder, 
        IConsoleAppResultOutput<CreateItemDataResult> createItemsResultOutput,
        IConsoleAppResultOutput<CreateAdaptiveItemsCommandResult> consoleAppResultOutput) 
        : base(mediatorBinder, createItemsResultOutput)
    {
        Name = "createAdaptiveItems";
        Description = "Add items to a subject to be used in adaptive tests.";

        VariantsOption = new Option<IEnumerable<string>>(
                ["--variants", "-v"],
                description: "List of language codes required for variants, this will create copies of items for each variants and link them. Then also add the relevant Adaptive tagging. Note that this is different to the Language Variants feature in Surpass")
        {
            IsRequired = false,
            AllowMultipleArgumentsPerToken = true
        };

        AddOption(VariantsOption);

        this.SetHandler(
            async (request, sender) => 
            { 
                var result = await sender.SendWithProgressAsync<CreateAdaptiveItemsCommandResult>(request, $"Creating adaptive items for subject {request.SubjectRef}...");
                consoleAppResultOutput.Print(result);
            },
            new CreateAdaptiveDataBinder(
                SubjectRefOption,
                NumberOfQuestionsOption,
                CategoryOption,
                ShowCorrectAnswerOption,
                TagsOption,
                MediaFolderOption,
                NumberOfMediaItemsPerItemOption,
                FixedNumberOfMediaPerItemOption,
                VariantsOption
            ),
            mediatorBinder
        );
    }
}