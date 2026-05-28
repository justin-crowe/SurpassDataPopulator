using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Binding;
using System.Linq;
using SurpassDataPopulator.Domain.Data.Builders.ItemTags;

namespace SurpassDataPopulator.Console.Cli.Verbs.Create.Items.Adaptive;

public class CreateAdaptiveDataBinder : BinderBase<Application.DataPopulation.Items.Adaptive.CreateAdaptiveItemsCommand>
{
    private readonly Option<string> _subjectRefOption;
    private readonly Option<int> _numberOfQuestionsOption;
    private readonly Option<IEnumerable<int>> _categoryOption;
    private readonly Option<bool> _showCorrectAnswerOption;
    private readonly Option<IEnumerable<string>> _tagsOption;
    private readonly Option<string> _mediaFolderOption;
    private readonly Option<int> _numberOfMediaItemsPerItemOption;
    private readonly Option<bool> _fixedNumberOfMediaPerItemOption;
    private readonly Option<IEnumerable<string>> _variantsOption;

    public CreateAdaptiveDataBinder(
        Option<string> subjectRefOption,
        Option<int> numberOfQuestionsOption,
        Option<IEnumerable<int>> categoryOption,
        Option<bool> showCorrectAnswerOption,
        Option<IEnumerable<string>> tagsOption,
        Option<string> mediaFolderOption,
        Option<int> numberOfMediaItemsPerItemOption,
        Option<bool> fixedNumberOfMediaPerItemOption,
        Option<IEnumerable<string>> variantsOption)
    {
        _subjectRefOption = subjectRefOption;
        _numberOfQuestionsOption = numberOfQuestionsOption;
        _categoryOption = categoryOption;
        _showCorrectAnswerOption = showCorrectAnswerOption;
        _tagsOption = tagsOption;
        _mediaFolderOption = mediaFolderOption;
        _numberOfMediaItemsPerItemOption = numberOfMediaItemsPerItemOption;
        _fixedNumberOfMediaPerItemOption = fixedNumberOfMediaPerItemOption;
        _variantsOption = variantsOption;
    }

    protected override Application.DataPopulation.Items.Adaptive.CreateAdaptiveItemsCommand GetBoundValue(BindingContext bindingContext)
    {
        return new Application.DataPopulation.Items.Adaptive.CreateAdaptiveItemsCommand
        {
            SubjectRef = bindingContext.ParseResult.GetValueForOption(_subjectRefOption),
            NumberOfQuestions = bindingContext.ParseResult.GetValueForOption(_numberOfQuestionsOption),
            Category = bindingContext.ParseResult.GetValueForOption(_categoryOption),
            ShowCorrectAnswer = bindingContext.ParseResult.GetValueForOption(_showCorrectAnswerOption),
            LanguageVariants = bindingContext.ParseResult.GetValueForOption(_variantsOption),
            Tags = bindingContext.ParseResult.GetValueForOption(_tagsOption)?.Select(x => new TagRequest(x)),
            MediaFolder = bindingContext.ParseResult.GetValueForOption(_mediaFolderOption),
            NumberOfMediaItemsPerItem = bindingContext.ParseResult.GetValueForOption(_numberOfMediaItemsPerItemOption),
            FixedNumberOfMediaPerItem = bindingContext.ParseResult.GetValueForOption(_fixedNumberOfMediaPerItemOption)
        };
    }
}