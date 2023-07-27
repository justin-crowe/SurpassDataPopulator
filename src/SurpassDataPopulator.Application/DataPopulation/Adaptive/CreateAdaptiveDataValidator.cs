using FluentValidation;
using SurpassDataPopulator.Application.Common.Validators.Subject;
using SurpassDataPopulator.Application.Interfaces.Services;

namespace SurpassDataPopulator.Application.DataPopulation.Adaptive
{
    public class CreateAdaptiveDataValidator : AbstractValidator<CreateAdaptiveData>
    {
        public CreateAdaptiveDataValidator(ISurpassApiService surpassApiService)
        {
            RuleFor(x => x.SubjectRef).IsValidSubject(surpassApiService);
        }
    }
}