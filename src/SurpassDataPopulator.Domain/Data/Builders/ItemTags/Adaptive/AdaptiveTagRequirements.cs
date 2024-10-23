using System;
using System.Collections.Generic;
using System.Globalization;
using SurpassDataPopulator.Domain.Common.Utilities;
using SurpassDataPopulator.Domain.Entities.Items;

namespace SurpassDataPopulator.Domain.Data.Builders.ItemTags.Adaptive
{
    public class AdaptiveTagRequirements : ITagRequirements
    {
        public string Type => "Adaptive";

        public List<ITagRequest> Requirements
        {
            get
            {
                return new List<ITagRequest>
                {
                    new TagRequest(AdaptiveTagNames.Curriculum, i => i.Category),
                    new TagRequest(AdaptiveTagNames.DifficultyScale, GetAdaptiveDifficulty),
                    new TagRequest(AdaptiveTagNames.DifficultyScaleDi, "1"),
                    new TagRequest(AdaptiveTagNames.DifficultyScaleGuess, "0"),
                    new TagRequest(AdaptiveTagNames.MasterId, _ => null),
                    new TagRequest(AdaptiveTagNames.Language, _ => null)
                };
            }
        }

        private static string GetAdaptiveDifficulty(Item item)
        {
            return item.Difficulty switch
            {
                Difficulty.Easy => (ThreadSafeRandom.ThisThreadsRandom.Next(0, 3) + double.Parse(GetRandomDouble())).ToString(CultureInfo.InvariantCulture),
                Difficulty.Medium => (ThreadSafeRandom.ThisThreadsRandom.Next(3, 7) + double.Parse(GetRandomDouble())).ToString(CultureInfo.InvariantCulture),
                Difficulty.Hard => (ThreadSafeRandom.ThisThreadsRandom.Next(7, 10) + double.Parse(GetRandomDouble())).ToString(CultureInfo.InvariantCulture),
                _ => throw new ArgumentOutOfRangeException(nameof(item.Difficulty))
            };
        }

        private static string GetRandomDouble()
        {
            return ThreadSafeRandom.ThisThreadsRandom.NextDouble().ToString("F5", CultureInfo.InvariantCulture);
        }
    }
}