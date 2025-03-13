using System.IO;
using FluentValidation;
using SurpassDataPopulator.Application.Common.Validators.Media;
using SurpassDataPopulator.Application.Common.Validators.Subject;
using SurpassDataPopulator.Application.Interfaces.Services;

namespace SurpassDataPopulator.Application.DataPopulation.Adaptive;

public class CreateAdaptiveDataValidator : AbstractValidator<CreateAdaptiveData>
{
    public CreateAdaptiveDataValidator(ISurpassApiService surpassApiService)
    {
        RuleFor(x => x.SubjectRef).IsValidSubject(surpassApiService);

        When(MediaFolderIsDefined, () =>
        {
            RuleFor(x => x.MediaFolder)
                .IsValidMediaFolder();
            RuleFor(x => x.NumberOfMediaItemsPerItem)
                .NotEmpty()
                .Must(IsValidForMediaFolder);
        });
    }

    private static bool MediaFolderIsDefined(CreateAdaptiveData options)
    {
        return !string.IsNullOrEmpty(options.MediaFolder);
    }

    private static bool IsValidForMediaFolder(CreateAdaptiveData options, int numberOfMediaItemsPerItem)
    {
        //TODO use interface here..
        return Directory.GetFiles(options.MediaFolder).Length >= numberOfMediaItemsPerItem;
    }
}