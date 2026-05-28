using System;
using System.Collections.Generic;
using SurpassDataPopulator.Application.Common.Models.CommandResults;

namespace SurpassDataPopulator.Application.DataPopulation.Items.Adaptive;

public class CreateAdaptiveItemsCommandResult : CommandResult<CreateAdaptiveItemsCommandResult>, ICommandArtifacts
{
    public List<ItemCreationSummary> Items { get; set; } = new();

    public int TotalItemsCreated { get; set; } = 0; 
    
    public int NumberOfCategories { get; set; }
    
    public int NumberOfTags { get; set; }

    public string SubjectReference { get; set; } = string.Empty;

    public bool HasMedia { get; set; }

    public bool IsAdaptive { get; set; }

    public List<string> LanguageVariants { get; set; } = new();

    public static CreateAdaptiveItemsCommandResult CreateSuccess(
        int totalItems,
        int categories,
        int tagsPerItem,
        string subjectReference,
        bool hasMedia = false,
        bool isAdaptive = false,
        List<string> languageVariants = null)
    {
        var categoryText = categories > 1
            ? $"{categories} categories"
            : "all categories";

        var message = $"Successfully created {totalItems} items in {categoryText}";
        if (isAdaptive)
        {
            message += " for adaptive testing";
        }

        return CreateSuccess(result =>
        {
            result.TotalItemsCreated = totalItems;
            result.NumberOfCategories = categories;
            result.NumberOfTags = tagsPerItem;
            result.SubjectReference = subjectReference;
            result.HasMedia = hasMedia;
            result.IsAdaptive = isAdaptive;
            result.LanguageVariants = languageVariants ?? [];
            result.Message = message;
        });
    }

    public static CreateAdaptiveItemsCommandResult CreateFailure(string errorMessage, Exception error)
    {
        return CreateFailure(error, result =>
        {
            result.Message = $"Failed to create items: {errorMessage}";
            result.TotalItemsCreated = 0;
        });
    }
}