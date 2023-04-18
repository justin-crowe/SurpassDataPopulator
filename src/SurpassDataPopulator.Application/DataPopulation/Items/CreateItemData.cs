using System.Collections.Generic;
using MediatR;
using SurpassDataPopulator.Domain.Data.Builders.ItemTags;

namespace SurpassDataPopulator.Application.DataPopulation.Items;

public class CreateItemData : IRequest
{
    public string SubjectRef { get; set; }
    public int NumberOfQuestions { get; set; }
    public IEnumerable<int> Category { get; set; }
    public bool ShowCorrectAnswer { get; set; }
    public IEnumerable<TagRequest> Tags { get; set; }
}