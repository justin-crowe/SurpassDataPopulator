using System.Collections.Generic;
using SurpassDataPopulator.Domain.Common.Utilities;
using SurpassDataPopulator.Domain.Entities.Tags;
using SurpassDataPopulator.Domain.Interfaces;

namespace SurpassDataPopulator.Domain.Entities.Items
{
    public class Item : IDeepCopy<Item>
    {
        public ItemType Type { get; set; }
        public List<string> QuestionText { get; set; }
        public int Mark { get; set; }
        public string Category { get; set; }
        public Difficulty Difficulty { get; set; }
        public List<Tag> Tags { get; set; } = new();

        public override Item DeepCopy()
        {
            return this.DeepCopyWithJsonSerialize();
        }
    }
}