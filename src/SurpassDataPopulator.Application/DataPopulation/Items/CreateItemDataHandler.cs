using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SurpassDataPopulator.Application.Common.Progress;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Domain.Data.Builders.Items;
using SurpassDataPopulator.Domain.Data.Builders.Media.Images;
using SurpassDataPopulator.Domain.Entities.Media.Images;

namespace SurpassDataPopulator.Application.DataPopulation.Items;

public class CreateItemDataHandler : IRequestHandler<CreateItemData, CreateItemDataResult>
{
    private readonly IItemGeneratorService _itemGeneratorService;
    private readonly ISurpassApiServiceFactory _surpassApiServiceFactory;
    private readonly IItemBuilder _itemBuilder;
    private readonly IFileStorage _fileStorage;
    private readonly IProgressContext _progressContext;

    public CreateItemDataHandler(
        IItemGeneratorService itemGeneratorService,
        ISurpassApiServiceFactory surpassApiServiceFactory,
        IItemBuilder itemBuilder,
        IFileStorage fileStorage,
        IProgressContext progressContext)
    {
        _surpassApiServiceFactory = surpassApiServiceFactory;
        _itemGeneratorService = itemGeneratorService;
        _itemBuilder = itemBuilder;
        _fileStorage = fileStorage;
        _progressContext = progressContext;
    }

    public async Task<CreateItemDataResult> Handle(CreateItemData request, CancellationToken cancellationToken)
    {
        var startTime = DateTime.UtcNow;

        _progressContext.ReportStatus("Generating items from Open Trivia API...");
        var generatedItems = await _itemGeneratorService.GenerateItemsAsync(
            new ItemBuildRequest(request.NumberOfQuestions, request.Category.ToList(), request.ShowCorrectAnswer, request.Tags));

        _progressContext.ReportStatus("Adding media to items...");
        AddMediaToItems(request, generatedItems);

        _progressContext.ReportStatus($"Importing {generatedItems.Items.Count} items to Surpass...");
        await _surpassApiServiceFactory.GetService().CreateItemsAsync(generatedItems.Items, request.SubjectRef);

        _progressContext.ReportStatus("Finalizing...");

        var processingTime = DateTime.UtcNow - startTime;

        var result = CreateItemDataResult.CreateSuccess(
            generatedItems.Items.Count,
            request.Category.ToDictionary(c => c.ToString(), c => request.NumberOfQuestions),
            processingTime,
            request.SubjectRef,
            request.MediaFolder != null);

        return result;
    }

    private void AddMediaToItems(CreateItemData request, ItemBuildResult generatedItems)
    {
        if (request.MediaFolder == null) return;

        var imageNames = _fileStorage.GetFiles(request.MediaFolder, SupportedImageFileTypes.FileTypes);
        var images = imageNames.ToDictionary(imageName => imageName, imageName => _fileStorage.ReadAllBytes(imageName));

        _itemBuilder.AddItemContent(generatedItems,
            new ItemImageRequest(request.NumberOfMediaItemsPerItem, request.FixedNumberOfMediaPerItem, images));
    }
}
