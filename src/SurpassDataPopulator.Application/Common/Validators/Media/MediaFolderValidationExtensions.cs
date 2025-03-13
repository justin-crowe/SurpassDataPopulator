using System.IO;
using System.Linq;
using FluentValidation;
using SurpassDataPopulator.Domain.Entities.Media.Images;

namespace SurpassDataPopulator.Application.Common.Validators.Media;

public static class MediaFolderValidationExtensions
{
    public static IRuleBuilderOptions<T, string> IsValidMediaFolder<T>(this IRuleBuilder<T, string> rule)
    {
        //This field isn't required, but validate the media folder if provided. does the folder exist and does it have supported images etc
        return rule
            .Must(Directory.Exists)
                .WithMessage($"Provided media folder doesn't exist")
            .Must(x => Directory.GetFiles(x).Count(file =>
                SupportedImageFileTypes.FileTypes.Any(file.ToLower().EndsWith)) > 0)
                .WithMessage($"There are no supported image file types in the provided media folder. Supported types are {string.Join(",",SupportedImageFileTypes.FileTypes)}");
    }
}