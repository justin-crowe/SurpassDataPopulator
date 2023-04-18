using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Domain.Data.Builders.Items;
using SurpassDataPopulator.Domain.Data.Builders.Items.Adaptive;

namespace SurpassDataPopulator.Application.DataPopulation.Adaptive
{
    public class CreateAdaptiveDataHandler : IRequestHandler<CreateAdaptiveData>
    {
        private readonly IItemGeneratorService _itemGeneratorService;
        private readonly IAdaptiveItemBuilder _adaptiveItemBuilder;
        private readonly ISurpassApiService _surpassApiService;

        public CreateAdaptiveDataHandler(IAdaptiveItemBuilder adaptiveItemBuilder, IItemGeneratorService itemGeneratorService, ISurpassApiService surpassApiService)
        {
            _surpassApiService = surpassApiService;
            _adaptiveItemBuilder = adaptiveItemBuilder;
            _itemGeneratorService = itemGeneratorService;
        }
        public async Task<Unit> Handle(CreateAdaptiveData request, CancellationToken cancellationToken)
        {
            //Generate the items and tag structure for adaptive
            var generatedItems = await _itemGeneratorService.GenerateItemsAsync(
                new ItemBuildRequest(request.NumberOfQuestions, request.Category.ToList(), request.ShowCorrectAnswer, request.Tags));
            
            _adaptiveItemBuilder.AddAdaptiveContent(generatedItems.Items, request.LanguageVariants.ToList());

            //import into surpass
            await _surpassApiService.CreateItemsAsync(generatedItems.Items, request.SubjectRef);

            return Unit.Value;

        }
    }
}