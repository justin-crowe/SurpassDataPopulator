using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SurpassDataPopulator.Application.Common.Models.CommandResults;
using SurpassDataPopulator.Application.Common.Progress;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Domain.Data.Builders.Items;
using SurpassDataPopulator.Domain.Data.Builders.Items.Adaptive;
using SurpassDataPopulator.Domain.Data.Builders.Media.Images;
using SurpassDataPopulator.Domain.Entities.Media.Images;

namespace SurpassDataPopulator.Application.DataPopulation.Items.Adaptive;

public class CreateAdaptiveItemsCommandHandler : IRequestHandler<CreateAdaptiveItemsCommand, CreateAdaptiveItemsCommandResult>
{
    private readonly IItemGeneratorService _itemGeneratorService;
    private readonly IAdaptiveItemBuilder _adaptiveItemBuilder;
    private readonly ISurpassApiServiceFactory _surpassApiServiceFactory;
    private readonly IItemBuilder _itemBuilder;
    private readonly IFileStorage _fileStorage;
    private readonly IProgressContext _progressContext;

    public CreateAdaptiveItemsCommandHandler(
        IAdaptiveItemBuilder adaptiveItemBuilder, 
        IItemGeneratorService itemGeneratorService, 
        ISurpassApiServiceFactory surpassApiServiceFactory, 
        IItemBuilder itemBuilder, 
        IFileStorage fileStorage,
        IProgressContext progressContext)
    {
        _surpassApiServiceFactory = surpassApiServiceFactory;
        _adaptiveItemBuilder = adaptiveItemBuilder;
        _itemGeneratorService = itemGeneratorService;
        _itemBuilder = itemBuilder;
        _fileStorage = fileStorage;
        _progressContext = progressContext;
    }
    
    public async Task<CreateAdaptiveItemsCommandResult> Handle(CreateAdaptiveItemsCommand request, CancellationToken cancellationToken)
    {
        _progressContext.ReportStatus($"Generating items...");
        var generatedItems = await GenerateAdaptiveItems(request);

        AddMediaToItems(request, generatedItems);

        _progressContext.ReportStatus("Adding adaptive content and variants...");
        _adaptiveItemBuilder.AddAdaptiveContent(generatedItems.Items, request.LanguageVariants.ToList());

        _progressContext.ReportStatus($"Importing {generatedItems.Items.Count} items to Surpass...");
        await _surpassApiServiceFactory.GetService().CreateItemsAsync(generatedItems.Items, request.SubjectRef);

        var result = CreateAdaptiveItemsCommandResult.CreateSuccess(
            generatedItems.Items.Count,
            request.Category.Count(),
            request.Tags.Count(),
            request.SubjectRef,
            request.MediaFolder != null,
            true,
            request.LanguageVariants.ToList());

        CreateArtifacts(request, result, generatedItems);

        return result;
    }

    private void AddMediaToItems(CreateAdaptiveItemsCommand request, ItemBuildResult generatedItems)
    {
        if (request.MediaFolder == null) return;

        _progressContext.ReportStatus("Adding media to items...");

        var imageNames = _fileStorage.GetFiles(request.MediaFolder, SupportedImageFileTypes.FileTypes);
        var images = imageNames.ToDictionary(imageName => imageName, imageName => _fileStorage.ReadAllBytes(imageName));

        _itemBuilder.AddItemContent(generatedItems,
            new ItemImageRequest(request.NumberOfMediaItemsPerItem, request.FixedNumberOfMediaPerItem, images));
    }

    private async Task<ItemBuildResult> GenerateAdaptiveItems(CreateAdaptiveItemsCommand request)
    {
        //Generate the items and tag structure for adaptive
        var generatedItems = await _itemGeneratorService.GenerateItemsAsync(
            new ItemBuildRequest(request.NumberOfQuestions, request.Category.ToList(), request.ShowCorrectAnswer, request.Tags));
        return generatedItems;
    }

    private static void CreateArtifacts(CreateAdaptiveItemsCommand request, CreateAdaptiveItemsCommandResult result, ItemBuildResult generatedItems)
    {
        AddManualTodoTasks(result);

        const string scaleId = "1"; // hard code this scale to use the same one as the tags this app creates
        AddSimpleCriteriaExample(request, result, generatedItems, scaleId);
        AddSegmentedCriteriaExample(request, result, generatedItems, scaleId);
        AddSegmentedCriteriaWithFixedItemsExample(request, result, generatedItems, scaleId);
    }

    private static void AddManualTodoTasks(CreateAdaptiveItemsCommandResult result)
    {
        result.AddToDoTasks([
            "Bulk update all items to Live status",
            "Create an Item Pool using Item search and the Live items in this Subject",
            "Create a Test / Test Form with adaptive section",
            "Assign the pool you created earlier to your adaptive section. Also assign one of the criteria examples in the artifacts as the rules. Set the form to live"
        ]);
    }

    private static void AddSegmentedCriteriaExample(CreateAdaptiveItemsCommand request, CreateAdaptiveItemsCommandResult result, ItemBuildResult generatedItems, string scaleId)
    {
        var allCategories = generatedItems.Items
            .Select(item => item.Category)
            .Distinct()
            .ToArray();

        if (allCategories.Length == 0) return;

        // Divide categories into 3 segments
        var categoriesPerSegment = Math.Max(1, allCategories.Length / 3);
        var segment1PrimaryCategory = allCategories.Take(categoriesPerSegment).FirstOrDefault() ?? allCategories[0];
        var segment2PrimaryCategory = allCategories.Skip(categoriesPerSegment).Take(categoriesPerSegment).FirstOrDefault() ?? allCategories[0];
        var segment3PrimaryCategory = allCategories.Skip(categoriesPerSegment * 2).FirstOrDefault() ?? allCategories[0];

        var segments = new JsonArray
        {
            new JsonObject
            {
                ["ID"] = "segmentID1",
                ["NextSegments"] = new JsonArray
                {
                    new JsonObject
                    {
                        ["ID"] = "segmentID2",
                        ["Lowerbound"] = 1
                    }
                },
                ["RandomItems"] = 1,
                ["RangeLower"] = 0,
                ["RangeUpper"] = 10,
                ["SuccessRate"] = 0.5,
                ["CurriculumTags"] = CreateCurriculumTagsForSegment(segment1PrimaryCategory, allCategories),
                ["MinimumSegmentLength"] = 12,
                ["MaximumSegmentLength"] = 17,
                ["MaximumLength"] = 18,
                ["StopStdError"] = 0.6,
                ["ExposureRate"] = 0.1,
                ["Randomesque"] = 1
            },
            new JsonObject
            {
                ["ID"] = "segmentID2",
                ["MinimumSegmentLength"] = 1,
                ["MaximumSegmentLength"] = 1,
                ["MaximumLength"] = 18,
                ["StopStdError"] = 999,
                ["ExposureRate"] = 0.1,
                ["Randomesque"] = 2,
                ["SuccessRate"] = 0.5,
                ["CurriculumTags"] = CreateCurriculumTagsForSegment(segment2PrimaryCategory, allCategories),
                ["ThreadCategoryCarry"] = false
            },
            new JsonObject
            {
                ["ID"] = "segmentID3",
                ["MinimumSegmentLength"] = 1,
                ["MaximumSegmentLength"] = 1,
                ["MaximumLength"] = 18,
                ["StopStdError"] = 999,
                ["ExposureRate"] = 0.1,
                ["Randomesque"] = 2,
                ["SuccessRate"] = 0.5,
                ["CurriculumTags"] = CreateCurriculumTagsForSegment(segment3PrimaryCategory, allCategories),
                ["ThreadCategoryCarry"] = false
            }
        };

        var segmentedCriteria = new JsonObject
        {
            ["ScaleData"] = new JsonObject
            {
                ["ID"] = scaleId,
                ["StartSegment"] = "segmentID1"
            },
            ["Segments"] = segments
        };

        result.AddArtifact(
            segmentedCriteria.AsJson(
                fileName: $"segmented-criteria-{request.SubjectRef}-{DateTime.UtcNow:yyyyMMdd_HHmmss}",
                description: $"A segmented algorithm criteria for an adaptive test form section")
        );
    }

    private static JsonArray CreateCurriculumTagsForSegment(string primaryCategory, string[] allCategories)
    {
        var tags = new JsonArray();

        // Add primary category with min/max items (10-15 items)
        tags.Add(new JsonObject
        {
            ["Tag"] = primaryCategory,
            ["MinimumItems"] = 10,
            ["MaximumItems"] = 15
        });

        // Add other categories with MaximumItems = 0
        foreach (var category in allCategories.Where(c => c != primaryCategory))
        {
            tags.Add(new JsonObject
            {
                ["Tag"] = category,
                ["MaximumItems"] = 0
            });
        }

        return tags;
    }

    private static void AddSimpleCriteriaExample(CreateAdaptiveItemsCommand request, CreateAdaptiveItemsCommandResult result, ItemBuildResult generatedItems, string scaleId)
    {
        // Add examples of test form criteria settings to be used for this set of items. This assumes no item pool edits to remove this data
        var curriculumTags = generatedItems.Items
            .Select(item => item.Category)
            .Distinct()
            .Select(x => new JsonObject { ["Tag"] = x })
            .ToArray();

        var algorithmCriteria = new JsonObject
        {
            ["ScaleData"] = new JsonObject { ["ID"] = scaleId }, 
            ["RandomItems"] = 1,
            ["RangeLower"] = 0,
            ["RangeUpper"] = 10,
            ["SuccessRate"] = 0.5,
            ["CurriculumTags"] = new JsonArray(curriculumTags.Cast<JsonNode>().ToArray()),
            ["MinimumLength"] = 25,
            ["MaximumLength"] = 35,
            ["StopStdError"] = 0.001,
            ["ExposureRate"] = 1
        };

        result.AddArtifact(
            algorithmCriteria.AsJson(
                fileName: $"simple-criteria-{request.SubjectRef}-{DateTime.UtcNow:yyyyMMdd_HHmmss}",
                description: $"A simple algorithm criteria for an adaptive test form section")
        );
    }

    private static void AddSegmentedCriteriaWithFixedItemsExample(CreateAdaptiveItemsCommand request, CreateAdaptiveItemsCommandResult result, ItemBuildResult generatedItems, string scaleId)
    {
        var allCategories = generatedItems.Items
            .Select(item => item.Category)
            .Distinct()
            .ToArray();

        if (allCategories.Length == 0) return;

        // Create a fixed set of items across 2 segments. Assume 10 items unless the generated items has fewer than 20 items, in which case use all items split into 2 segments
        var fixedItemsPerSegment = Math.Max(1, Math.Min(10, result.Items.Count / 2));

        var segment1Items = result.Items.Take(fixedItemsPerSegment).Select(i => i.ItemId).ToArray();
        var segment2Items = result.Items.Skip(fixedItemsPerSegment).Take(fixedItemsPerSegment).Select(i => i.ItemId).ToArray();

        var segments = new JsonArray
        {
            new JsonObject
            {
                ["ID"] = "segmentID1",
                ["LinearItems"] = CreateLinearItemListForSegment(segment1Items)

            },
            new JsonObject
            {
                ["ID"] = "segmentID2",
                ["LinearItems"] = CreateLinearItemListForSegment(segment2Items)
            }
        };

        var segmentedCriteria = new JsonObject
        {
            ["ScaleData"] = new JsonObject
            {
                ["ID"] = scaleId,
                ["StartSegment"] = "segmentID1"
            },
            ["Segments"] = segments
        };

        result.AddArtifact(
            segmentedCriteria.AsJson(
                fileName: $"fixed-items-segmented-criteria-{request.SubjectRef}-{DateTime.UtcNow:yyyyMMdd_HHmmss}",
                description: $"A fixed items list within a segmented algorithm criteria for an adaptive test form section")
        );

    }

    private static JsonArray CreateLinearItemListForSegment(string[] itemIds)
    {
        var result = new JsonArray();
        foreach (var itemId in itemIds)
        {
            result.Add(itemId);
        }
        return result;
    }
}