using FluentValidation;
using SurpassDataPopulator.Application.Interfaces.Services;

namespace SurpassDataPopulator.Application.DataPopulation.Adaptive
{
    public class CreateAdaptiveDataValidator : AbstractValidator<CreateAdaptiveData>
    {
        public CreateAdaptiveDataValidator(ISurpassApiService surpassApiService)
        {
            RuleFor(x => x.SubjectRef).NotEmpty();
            RuleFor(x => x.SubjectRef).MustAsync(async (subjectRef, _)
                => await surpassApiService.SubjectExistsAsync(subjectRef)).WithMessage($"Subject doesn't exist, or the api isn't available.");
        }
    }
}