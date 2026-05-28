using SurpassDataPopulator.Application.DataPopulation.Items;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using SurpassDataPopulator.Console.Display.Mappers;
using SurpassDataPopulator.Domain.Data.Builders.ItemTags;

namespace SurpassDataPopulator.Console.Cli.Verbs.Create.Items;

public class CreateItems : Command
{
    public Option<string> SubjectRefOption { get; }
    public Option<int> NumberOfQuestionsOption { get; }
    public Option<IEnumerable<int>> CategoryOption { get; }
    public Option<bool> ShowCorrectAnswerOption { get; }
    public Option<IEnumerable<string>> TagsOption { get; }
    public Option<string> MediaFolderOption { get; }
    public Option<int> NumberOfMediaItemsPerItemOption { get; }
    public Option<bool> FixedNumberOfMediaPerItemOption { get; }

    public CreateItems(ProgressAwareMediatrBinder mediatorBinder, IConsoleAppResultOutput<CreateItemDataResult> consoleAppResultOutput)
        : base("createItems", "Add items to a subject.")
    {
        SubjectRefOption = new Option<string>(
            ["--subjectRef","-s"],
            description: "The subject reference")
        { IsRequired = true };

        NumberOfQuestionsOption = new Option<int>(
            ["--numberOfItemsPerCategory", "-n"],
            description: "The number of items per category")
        { IsRequired = true };

        CategoryOption = new Option<IEnumerable<int>>(
            ["--category", "-c"],
            description: "The open trivia category");

        ShowCorrectAnswerOption = new Option<bool>(
            name: "--showCorrect",
            description: "Is the correct answer added to the stem",
            getDefaultValue: () => true);

        TagsOption = new Option<IEnumerable<string>>(
            name: "--tags",
            description: "Tags to add to each item. Use the format 'name:value' for static tags",
            getDefaultValue: () => new List<string>())
        {
            IsRequired = false,
            AllowMultipleArgumentsPerToken = true
        };

        MediaFolderOption = new Option<string>(
            name: "--mediaFolder",
            description: "A path to a folder where media is stored. Images are only supported and a random image from this folder will be added to each item.");

        NumberOfMediaItemsPerItemOption = new Option<int>(
            name: "--mediaItems",
            description: "Number of media items from the MediaFolder to assign to each item",
            getDefaultValue: () => 0);

        FixedNumberOfMediaPerItemOption = new Option<bool>(
            name: "--fixedMedia",
            description: "If true, the number of media items per item will be fixed to the value of 'mediaItems'. If false, a random number (0 - 'mediaItems') of media items will be assigned to each item.",
            getDefaultValue: () => false);

        AddOption(SubjectRefOption);
        AddOption(NumberOfQuestionsOption);
        AddOption(CategoryOption);
        AddOption(ShowCorrectAnswerOption);
        AddOption(TagsOption);
        AddOption(MediaFolderOption);
        AddOption(NumberOfMediaItemsPerItemOption);
        AddOption(FixedNumberOfMediaPerItemOption);

        this.SetHandler(
            async (request, sender) =>
            {
                var result = await sender.SendWithProgressAsync<CreateItemDataResult>(request, $"Creating items for subject {request.SubjectRef}...");
                consoleAppResultOutput.Print(result);
            },
            new Argument<CreateItemData>(
                "request",
                parse: result =>
                {
                    var subjectRef = result.GetValueForOption(SubjectRefOption);
                    var numberOfQuestions = result.GetValueForOption(NumberOfQuestionsOption);
                    var category = result.GetValueForOption(CategoryOption);
                    var showCorrectAnswer = result.GetValueForOption(ShowCorrectAnswerOption);
                    var tags = result.GetValueForOption(TagsOption);
                    var mediaFolder = result.GetValueForOption(MediaFolderOption);
                    var numberOfMediaItemsPerItem = result.GetValueForOption(NumberOfMediaItemsPerItemOption);
                    var fixedNumberOfMediaPerItem = result.GetValueForOption(FixedNumberOfMediaPerItemOption);

                    return new CreateItemData
                    {
                        SubjectRef = subjectRef,
                        NumberOfQuestions = numberOfQuestions,
                        Category = category,
                        ShowCorrectAnswer = showCorrectAnswer,
                        Tags = tags?.Select(x => new TagRequest(x)),
                        MediaFolder = mediaFolder,
                        NumberOfMediaItemsPerItem = numberOfMediaItemsPerItem,
                        FixedNumberOfMediaPerItem = fixedNumberOfMediaPerItem
                    };
                }
            ),
            mediatorBinder
        );
    }
}