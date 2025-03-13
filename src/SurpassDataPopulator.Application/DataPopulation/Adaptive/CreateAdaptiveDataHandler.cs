using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Domain.Data.Builders.Items;
using SurpassDataPopulator.Domain.Data.Builders.Items.Adaptive;
using SurpassDataPopulator.Domain.Data.Builders.Media.Images;
using SurpassDataPopulator.Domain.Entities.Media.Images;

namespace SurpassDataPopulator.Application.DataPopulation.Adaptive;

public class CreateAdaptiveDataHandler : IRequestHandler<CreateAdaptiveData>
{
    private readonly IItemGeneratorService _itemGeneratorService;
    private readonly IAdaptiveItemBuilder _adaptiveItemBuilder;
    private readonly ISurpassApiService _surpassApiService;
    private readonly IItemBuilder _itemBuilder;
    private readonly IFileStorage _fileStorage;

    public CreateAdaptiveDataHandler(IAdaptiveItemBuilder adaptiveItemBuilder, IItemGeneratorService itemGeneratorService, ISurpassApiService surpassApiService, IItemBuilder itemBuilder, IFileStorage fileStorage)
    {
        _surpassApiService = surpassApiService;
        _adaptiveItemBuilder = adaptiveItemBuilder;
        _itemGeneratorService = itemGeneratorService;
        _itemBuilder = itemBuilder;
        _fileStorage = fileStorage;
    }
    public async Task<Unit> Handle(CreateAdaptiveData request, CancellationToken cancellationToken)
    {
        //Generate the items and tag structure for adaptive
        var generatedItems = await _itemGeneratorService.GenerateItemsAsync(
            new ItemBuildRequest(request.NumberOfQuestions, request.Category.ToList(), request.ShowCorrectAnswer, request.Tags));

        if(request.MediaFolder != null)
        {
            var imageNames = _fileStorage.GetFiles(request.MediaFolder, SupportedImageFileTypes.FileTypes);
            var images = imageNames.ToDictionary(imageName => imageName, imageName => _fileStorage.ReadAllBytes(imageName));

            _itemBuilder.AddItemContent(generatedItems,
                new ItemImageRequest(request.NumberOfMediaItemsPerItem, request.FixedNumberOfMediaPerItem, images));
        }
            
        _adaptiveItemBuilder.AddAdaptiveContent(generatedItems.Items, request.LanguageVariants.ToList());

        //import into surpass
        await _surpassApiService.CreateItemsAsync(generatedItems.Items, request.SubjectRef);

        return Unit.Value;

    }
}