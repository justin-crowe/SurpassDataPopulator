using System.Collections.Generic;
using SurpassDataPopulator.Domain.Common.Utilities;

namespace SurpassDataPopulator.Domain.Entities.Items.QuestionTypes.MultipleChoice
{
    public class MultipleChoiceItem : Item
    {
        public IReadOnlyList<MultipleChoiceItemOption> AnswerOptions { get; init; }
        
        public override MultipleChoiceItem DeepCopy()
        {
            return this.DeepCopyWithJsonSerialize();
        }
    }
}