using MediatR;

namespace SurpassDataPopulator.Application.DataPopulation.Subject;

public class CreateSubjectCommand : IRequest<CreateSubjectCommandResult>
{
    public string Name { get; set; }
    public string Reference { get; set; }

}