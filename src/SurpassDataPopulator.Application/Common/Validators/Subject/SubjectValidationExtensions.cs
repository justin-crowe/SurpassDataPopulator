using FluentValidation;
using SurpassDataPopulator.Application.Interfaces.Services;

namespace SurpassDataPopulator.Application.Common.Validators.Subject;

public static class SubjectValidationExtensions
{
    public static IRuleBuilderOptions<T, string> IsValidSubject<T>(this IRuleBuilder<T, string> rule, ISurpassApiServiceFactory surpassApiServiceFactory)
    {
        return rule
            .NotEmpty()
            .MustAsync(async (subjectRef, _) => await surpassApiServiceFactory.GetService().SubjectExistsAsync(subjectRef))
                .WithMessage($"Subject doesn't exist, or the api isn't available.");
    }
}