using SurpassDataPopulator.Domain.Common.Utilities;

namespace SurpassDataPopulator.Domain.Entities.Items.QuestionTypes.EitherOr;

public class EitherOrItem : Item
{
    public bool CorrectAnswer { get; init; }

    public override EitherOrItem DeepCopy()
    {
        return this.DeepCopyWithJsonSerialize();
    }
}