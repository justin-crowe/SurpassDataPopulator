using System.Linq;
using System.Threading.Tasks;
using CommandLine;
using MediatR;
using SurpassDataPopulator.Application.DataPopulation.Adaptive;
using SurpassDataPopulator.Console.Cli.Verbs.Create.Adaptive;
using SurpassDataPopulator.Domain.Data.Builders.ItemTags;

namespace SurpassDataPopulator.Console;

public class DataPopulatorApplication
{
    private readonly ISender _mediator;

    public DataPopulatorApplication(ISender mediatr)
    {
        _mediator = mediatr;
    }

    public async Task RunAsync(string[] args)
    {
        await Parser.Default.ParseArguments<CreateAdaptiveItems>(args)
            .WithParsedAsync<CreateAdaptiveItems>(async options => await AddAdaptiveItemsToSubject(options));
    }

    private async Task AddAdaptiveItemsToSubject(CreateAdaptiveItems options)
    {
        await _mediator.Send(new CreateAdaptiveData
        {
            SubjectRef = options.SubjectRef,
            Category = options.Category,
            NumberOfQuestions = options.NumberOfQuestions,
            ShowCorrectAnswer = options.ShowCorrectAnswer,
            LanguageVariants = options.LanguageVariants,
            Tags = options.Tags.Select(x => new TagRequest(x)),
            MediaFolder = options.MediaFolder,
            NumberOfMediaItemsPerItem = options.NumberOfMediaItemsPerItem,
            FixedNumberOfMediaPerItem = options.FixedNumberOfMediaPerItem
        });
    }
}