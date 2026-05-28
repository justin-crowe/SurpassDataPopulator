using SurpassDataPopulator.Application.DataPopulation.Items.Adaptive;
using SurpassDataPopulator.Domain.Data.Builders.ItemTags;

namespace SurpassDataPopulator.Application.IntegrationTests.Builders;

/// <summary>
/// Builder for creating test instances of CreateAdaptiveItemsCommand.
/// </summary>
public class CreateAdaptiveItemsCommandBuilder
{
    private string _subjectRef = "TEST_SUBJECT";
    private int _numberOfQuestions = 10;
    private List<int> _categories = [9]; // General Knowledge
    private bool _showCorrectAnswer = false;
    private List<TagRequest> _tags = [];
    private string? _mediaFolder = null;
    private int _numberOfMediaItemsPerItem = 0;
    private bool _fixedNumberOfMediaPerItem = false;
    private List<string> _languageVariants = ["en"];

    public CreateAdaptiveItemsCommandBuilder WithSubjectRef(string subjectRef)
    {
        _subjectRef = subjectRef;
        return this;
    }

    public CreateAdaptiveItemsCommandBuilder WithNumberOfQuestions(int numberOfQuestions)
    {
        _numberOfQuestions = numberOfQuestions;
        return this;
    }

    public CreateAdaptiveItemsCommandBuilder WithCategories(params int[] categories)
    {
        _categories = [..categories];
        return this;
    }

    public CreateAdaptiveItemsCommandBuilder WithShowCorrectAnswer(bool showCorrectAnswer)
    {
        _showCorrectAnswer = showCorrectAnswer;
        return this;
    }

    public CreateAdaptiveItemsCommandBuilder WithTags(params TagRequest[] tags)
    {
        _tags = [..tags];
        return this;
    }

    public CreateAdaptiveItemsCommandBuilder WithMediaFolder(string mediaFolder)
    {
        _mediaFolder = mediaFolder;
        return this;
    }

    public CreateAdaptiveItemsCommandBuilder WithMediaItems(int numberOfMediaItemsPerItem, bool fixedNumber = false)
    {
        _numberOfMediaItemsPerItem = numberOfMediaItemsPerItem;
        _fixedNumberOfMediaPerItem = fixedNumber;
        return this;
    }

    public CreateAdaptiveItemsCommandBuilder WithLanguageVariants(params string[] variants)
    {
        _languageVariants = [..variants];
        return this;
    }

    public CreateAdaptiveItemsCommand Build()
    {
        return new CreateAdaptiveItemsCommand
        {
            SubjectRef = _subjectRef,
            NumberOfQuestions = _numberOfQuestions,
            Category = _categories,
            ShowCorrectAnswer = _showCorrectAnswer,
            Tags = _tags,
            MediaFolder = _mediaFolder,
            NumberOfMediaItemsPerItem = _numberOfMediaItemsPerItem,
            FixedNumberOfMediaPerItem = _fixedNumberOfMediaPerItem,
            LanguageVariants = _languageVariants
        };
    }
}
