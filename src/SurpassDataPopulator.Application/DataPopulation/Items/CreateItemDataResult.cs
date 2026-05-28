using System;
using System.Collections.Generic;
using System.Linq;
using SurpassDataPopulator.Application.Common.Models.CommandResults;

namespace SurpassDataPopulator.Application.DataPopulation.Items;

/// <summary>
/// Display result for item creation operations
/// </summary>
public class CreateItemDataResult : CommandResult<CreateItemDataResult>
{
    public string Message { get; set; } = string.Empty;
    /// <summary>
    /// Total number of items created
    /// </summary>
    public int TotalItemsCreated { get; set; }

    /// <summary>
    /// Number of items created per category
    /// </summary>
    public Dictionary<string, int> ItemsByCategory { get; set; } = new();

    /// <summary>
    /// Sample of created items for display
    /// </summary>
    public List<ItemCreationSummary> Items { get; set; } = new();

    /// <summary>
    /// How long the operation took
    /// </summary>
    public TimeSpan ProcessingTime { get; set; }

    /// <summary>
    /// Subject reference where items were created
    /// </summary>
    public string SubjectReference { get; set; } = string.Empty;

    /// <summary>
    /// Whether media was included in the items
    /// </summary>
    public bool HasMedia { get; set; }

    /// <summary>
    /// Creates a successful item creation result
    /// </summary>
    public static CreateItemDataResult CreateSuccess(
        int totalItems, 
        Dictionary<string, int> itemsByCategory, 
        TimeSpan processingTime,
        string subjectReference,
        bool hasMedia = false)
    {
        var categoryText = itemsByCategory.Count > 1 
            ? $"{itemsByCategory.Count} categories" 
            : itemsByCategory.Keys.FirstOrDefault() ?? "unknown category";

        var message = $"Successfully created {totalItems} items in {categoryText}";

        return CreateSuccess(result =>
        {
            result.TotalItemsCreated = totalItems;
            result.ItemsByCategory = itemsByCategory;
            result.ProcessingTime = processingTime;
            result.SubjectReference = subjectReference;
            result.HasMedia = hasMedia;
            result.Message = message;
        });
    }

    public static CreateItemDataResult CreateFailure(string errorMessage, Exception error)
    {
        return CreateFailure(error, result =>
        {
            result.Message = $"Failed to create items: {errorMessage}";
            result.TotalItemsCreated = 0;
        });
    }
}

/// <summary>
/// Summary information about a created item
/// </summary>
public class ItemCreationSummary
{
    /// <summary>
    /// Item ID in Surpass
    /// </summary>
    public string ItemId { get; set; } = string.Empty;

    /// <summary>
    /// Item title/question stem
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Category the item belongs to
    /// </summary>
    public string Category { get; set; } = string.Empty;

    /// <summary>
    /// Whether the item has associated media
    /// </summary>
    public bool HasMedia { get; set; }

    /// <summary>
    /// Tags applied to the item
    /// </summary>
    public List<string> Tags { get; set; } = new();

    /// <summary>
    /// Language variant if applicable
    /// </summary>
    public string LanguageVariant { get; set; }
}