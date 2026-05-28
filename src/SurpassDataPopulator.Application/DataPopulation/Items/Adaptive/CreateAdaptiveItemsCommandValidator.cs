using FluentValidation;
using SurpassDataPopulator.Application.Common.Validators.Media;
using SurpassDataPopulator.Application.Common.Validators.Subject;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Domain.Entities.Media.Images;

namespace SurpassDataPopulator.Application.DataPopulation.Items.Adaptive;

public class CreateAdaptiveItemsCommandValidator : AbstractValidator<CreateAdaptiveItemsCommand>
{
    private readonly IFileStorage _fileStorage;

    public CreateAdaptiveItemsCommandValidator(
        ISurpassApiServiceFactory surpassApiServiceFactory,
        IFileStorage fileStorage)
    {
        _fileStorage = fileStorage;

        RuleFor(x => x.SubjectRef).IsValidSubject(surpassApiServiceFactory);

        When(MediaFolderIsDefined, () =>
        {
            RuleFor(x => x.MediaFolder)
                .IsValidMediaFolder(_fileStorage);
            RuleFor(x => x.NumberOfMediaItemsPerItem)
                .NotEmpty()
                .Must(IsValidForMediaFolder);
        });
    }

    private static bool MediaFolderIsDefined(CreateAdaptiveItemsCommand options)
    {
        return !string.IsNullOrEmpty(options.MediaFolder);
    }

    private bool IsValidForMediaFolder(CreateAdaptiveItemsCommand options, int numberOfMediaItemsPerItem)
    {
        if (!_fileStorage.DirectoryExists(options.MediaFolder))
        {
            return false;
        }

        return _fileStorage.GetFiles(options.MediaFolder, SupportedImageFileTypes.FileTypes).Count >= numberOfMediaItemsPerItem;
    }
}