using System;
using System.Collections.Generic;
using System.Globalization;
using SurpassDataPopulator.Domain.Common.Utilities;
using SurpassDataPopulator.Domain.Entities.Items;

namespace SurpassDataPopulator.Domain.Data.Builders.ItemTags.Adaptive;

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
            Difficulty.Easy => GetFormattedDifficulty(0, 3),
            Difficulty.Medium => GetFormattedDifficulty(3, 7),
            Difficulty.Hard => GetFormattedDifficulty(7, 10),
            _ => throw new ArgumentOutOfRangeException(nameof(item.Difficulty))
        };
    }

    private static string GetFormattedDifficulty(int min, int max)
    {
        var randomValue = ThreadSafeRandom.ThisThreadsRandom.Next(min, max) + ThreadSafeRandom.ThisThreadsRandom.NextDouble();
        return randomValue.ToString("F5", CultureInfo.InvariantCulture);
    }
}