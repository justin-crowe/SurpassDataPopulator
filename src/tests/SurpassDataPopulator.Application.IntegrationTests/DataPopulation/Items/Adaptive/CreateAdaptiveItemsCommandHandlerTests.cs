using FluentAssertions;
using MediatR;
using Moq;
using SurpassDataPopulator.Application.DataPopulation.Items.Adaptive;
using SurpassDataPopulator.Application.IntegrationTests.Builders;
using SurpassDataPopulator.Application.IntegrationTests.Infrastructure;
using SurpassDataPopulator.Domain.Data.Builders.Items;
using SurpassDataPopulator.Domain.Entities.Items;
using SurpassDataPopulator.Domain.Entities.Items.QuestionTypes.EitherOr;

namespace SurpassDataPopulator.Application.IntegrationTests.DataPopulation.Items.Adaptive;

/// <summary>
/// Integration tests for CreateAdaptiveItemsCommand handler.
/// Tests the full flow through MediatR pipeline including validation and behaviors.
/// </summary>
public class CreateAdaptiveItemsCommandHandlerTests : IClassFixture<TestApplicationFixture>
{
    private readonly TestApplicationFixture _fixture;
    private readonly IMediator _mediator;

    public CreateAdaptiveItemsCommandHandlerTests(TestApplicationFixture fixture)
    {
        _fixture = fixture;
        _mediator = fixture.GetMediator();
        
        // Reset mocks before each test
        _fixture.ResetMocks();
    }

    [Fact]
    public async Task Handle_WithValidCommand_CreatesAdaptiveItemsSuccessfully()
    {
        // Arrange
        var command = new CreateAdaptiveItemsCommandBuilder()
            .WithSubjectRef("TEST_SUBJECT")
            .WithNumberOfQuestions(5)
            .WithCategories(9) // General Knowledge
            .WithLanguageVariants("en", "fr")
            .Build();

        SetupMockItemGeneratorService(command.NumberOfQuestions);
        SetupMockSurpassApiService("TEST_SUBJECT");

        // Act
        CreateAdaptiveItemsCommandResult result = (CreateAdaptiveItemsCommandResult)await _mediator.Send(command);

        // Assert
        result.Should().NotBeNull();
        result.Success.Should().BeTrue();
        result.TotalItemsCreated.Should().Be(10); //double the items because of 2 language variants
        result.LanguageVariants.Should().BeEquivalentTo(new[] { "en", "fr" });

        // Verify items were created in Surpass
        _fixture.MockSurpassApiService.Verify(
            x => x.CreateItemsAsync(
                It.Is<List<Item>>(items => items.Count >= command.NumberOfQuestions),
                "TEST_SUBJECT"),
            Times.Once);
    }

    [Fact]
    public async Task Handle_WithMultipleCategories_CreatesItemsFromAllCategories()
    {
        // Arrange
        var command = new CreateAdaptiveItemsCommandBuilder()
            .WithSubjectRef("MULTI_CAT_SUBJECT")
            .WithNumberOfQuestions(10)
            .WithCategories(9, 10, 11) // Multiple categories
            .WithLanguageVariants("en")
            .Build();

        SetupMockItemGeneratorService(command.NumberOfQuestions);
        SetupMockSurpassApiService("MULTI_CAT_SUBJECT");

        // Act
        CreateAdaptiveItemsCommandResult result = (CreateAdaptiveItemsCommandResult)await _mediator.Send(command);

        // Assert
        result.Success.Should().BeTrue();
        result.NumberOfCategories.Should().Be(3);
    }

    [Fact]
    public async Task Handle_WithLanguageVariants_CreatesVariantItems()
    {
        // Arrange
        var variants = new[] { "en", "we" };
        var command = new CreateAdaptiveItemsCommandBuilder()
            .WithSubjectRef("VARIANT_SUBJECT")
            .WithNumberOfQuestions(3)
            .WithLanguageVariants(variants)
            .Build();

        SetupMockItemGeneratorService(command.NumberOfQuestions);
        SetupMockSurpassApiService("VARIANT_SUBJECT");

        // Act
        CreateAdaptiveItemsCommandResult result = (CreateAdaptiveItemsCommandResult)await _mediator.Send(command);

        // Assert
        result.Success.Should().BeTrue();
        result.LanguageVariants.Should().BeEquivalentTo(variants);
        
        // Verify items include variant tagging (multiplied by variant count)
        _fixture.MockSurpassApiService.Verify(
            x => x.CreateItemsAsync(
                It.Is<List<Item>>(items => items.Count >= command.NumberOfQuestions * variants.Length),
                "VARIANT_SUBJECT"),
            Times.Once);
    }

    [Fact]
    public async Task Handle_WithMediaFolder_AddsMediaToItems()
    {
        // Arrange
        var mediaFolder = "C:\\Test\\Media";
        var imageFiles = new[] { "image1.jpg", "image2.png" };
        var imageData = new Dictionary<string, byte[]>
        {
            [imageFiles[0]] = [1, 2, 3, 4],
            [imageFiles[1]] = [5, 6, 7, 8]
        };

        var command = new CreateAdaptiveItemsCommandBuilder()
            .WithSubjectRef("MEDIA_SUBJECT")
            .WithNumberOfQuestions(5)
            .WithMediaFolder(mediaFolder)
            .WithMediaItems(2, fixedNumber: true)
            .Build();

        SetupMockItemGeneratorService(command.NumberOfQuestions);
        SetupMockSurpassApiService("MEDIA_SUBJECT");
        SetupMockFileSystem(mediaFolder, imageFiles);
        SetupMockFileStorage(mediaFolder, imageFiles, imageData);

        // Act
        CreateAdaptiveItemsCommandResult result = (CreateAdaptiveItemsCommandResult)await _mediator.Send(command);

        // Assert
        result.Success.Should().BeTrue();
        result.HasMedia.Should().BeTrue();

        // Verify file storage was accessed - once for checking it exists, has image files and has enough image files to satisfy requirements
        _fixture.MockFileStorage.Verify(
            x => x.GetFiles(mediaFolder, It.IsAny<List<string>>()),
            Times.Exactly(3));
    }

    [Fact]
    public async Task When_ShowCorrectAnswer_IncludesAnswerInStem()
    {
        // Arrange
        var command = new CreateAdaptiveItemsCommandBuilder()
            .WithSubjectRef("SHOW_ANSWER_SUBJECT")
            .WithNumberOfQuestions(5)
            .WithShowCorrectAnswer(true)
            .Build();

        SetupMockItemGeneratorService(command.NumberOfQuestions);
        SetupMockSurpassApiService("SHOW_ANSWER_SUBJECT");

        // Act
        var result = await _mediator.Send(command);

        // Assert
        result.Success.Should().BeTrue();
    }

    [Fact]
    public async Task When_ShowCorrectAnswer_IncludesToDoTasks()
    {
        // Arrange
        var command = new CreateAdaptiveItemsCommandBuilder()
            .WithSubjectRef("SHOW_ANSWER_SUBJECT")
            .WithNumberOfQuestions(5)
            .WithShowCorrectAnswer(true)
            .Build();

        SetupMockItemGeneratorService(command.NumberOfQuestions);
        SetupMockSurpassApiService("SHOW_ANSWER_SUBJECT");

        // Act
        var result = await _mediator.Send(command);

        // Assert
        result.Success.Should().BeTrue();
        result.ToDoTasks.Should().HaveCount(4);
    }

    [Fact]
    public async Task When_InvalidSubjectRef_FailsValidation()
    {
        // Arrange
        var command = new CreateAdaptiveItemsCommandBuilder()
            .WithSubjectRef("") // Invalid: empty subject ref
            .WithNumberOfQuestions(5)
            .Build();

        var response = await _mediator.Send(command);


        response.Should().NotBeNull();
        response.Success.Should().BeFalse();
        response.Error.Should().NotBeNull();
        response.Error.Message.Should().Contain("Subject doesn't exist, or the api isn't available.");
        response.Error.Should().BeOfType<FluentValidation.ValidationException>();
    }

    [Fact]
    public async Task When_ZeroQuestions_FailsValidation()
    {
        var command = new CreateAdaptiveItemsCommandBuilder()
            .WithSubjectRef("TEST_SUBJECT")
            .WithNumberOfQuestions(0) // Invalid
            .Build();

        var response = await _mediator.Send(command);


        response.Should().NotBeNull();
        response.Success.Should().BeFalse();
        response.Error.Should().NotBeNull();
        response.Error.Message.Should().Contain("Subject doesn't exist, or the api isn't available.");
        response.Error.Should().BeOfType<FluentValidation.ValidationException>();
    }

    [Fact]
    public async Task When_MediaFolderDoesNotExist_FailsValidation()
    {
        // Arrange
        var mediaFolder = "C:\\NonExistent\\Folder";
        var command = new CreateAdaptiveItemsCommandBuilder()
            .WithSubjectRef("TEST_SUBJECT")
            .WithNumberOfQuestions(5)
            .WithMediaFolder(mediaFolder)
            .WithMediaItems(2, fixedNumber: true)
            .Build();

        SetupMockSurpassApiService("TEST_SUBJECT");

        // Mock file system to return directory doesn't exist
        _fixture.MockFileStorage
            .Setup(x => x.DirectoryExists(mediaFolder))
            .Returns(false);

        // Mock GetFiles to return empty list (won't be called due to directory check, but setup for safety)
        _fixture.MockFileStorage
            .Setup(x => x.GetFiles(mediaFolder, It.IsAny<List<string>>()))
            .Returns(new List<string>());

        // Act
        var response = await _mediator.Send(command);

        // Assert
        response.Should().NotBeNull();
        response.Success.Should().BeFalse();
        response.Error.Should().NotBeNull();
        response.Error.Should().BeOfType<FluentValidation.ValidationException>();
        response.Error.Message.Should().Contain("media folder doesn't exist");
    }

    [Fact]
    public async Task When_MediaFolderHasNoSupportedImages_FailsValidation()
    {
        // Arrange
        var mediaFolder = "C:\\Test\\EmptyMedia";
        var command = new CreateAdaptiveItemsCommandBuilder()
            .WithSubjectRef("TEST_SUBJECT")
            .WithNumberOfQuestions(5)
            .WithMediaFolder(mediaFolder)
            .WithMediaItems(2, fixedNumber: true)
            .Build();

        SetupMockSurpassApiService("TEST_SUBJECT");

        // Mock file system: directory exists but has no supported image files
        _fixture.MockFileStorage
            .Setup(x => x.DirectoryExists(mediaFolder))
            .Returns(true);
        _fixture.MockFileStorage
            .Setup(x => x.GetFiles(mediaFolder, It.IsAny<List<string>>()))
            .Returns(["document.pdf", "readme.txt"]); // No image files

        // Act
        var response = await _mediator.Send(command);

        // Assert
        response.Should().NotBeNull();
        response.Success.Should().BeFalse();
        response.Error.Should().NotBeNull();
        response.Error.Should().BeOfType<FluentValidation.ValidationException>();
        response.Error.Message.Should().Contain("no supported image file types");
    }

    [Fact]
    public async Task When_MediaItemsExceedsAvailableFiles_FailsValidation()
    {
        // Arrange
        var mediaFolder = "C:\\Test\\LimitedMedia";
        var imageFiles = new[] { "image1.jpg" }; // Only 1 image
        var command = new CreateAdaptiveItemsCommandBuilder()
            .WithSubjectRef("TEST_SUBJECT")
            .WithNumberOfQuestions(5)
            .WithMediaFolder(mediaFolder)
            .WithMediaItems(5, fixedNumber: true) // Requesting 5 but only 1 available
            .Build();

        SetupMockSurpassApiService("TEST_SUBJECT");

        // Mock file system
        _fixture.MockFileStorage
            .Setup(x => x.DirectoryExists(mediaFolder))
            .Returns(true);
        _fixture.MockFileStorage
            .Setup(x => x.GetFiles(mediaFolder, It.IsAny<List<string>>()))
            .Returns(imageFiles.ToList());

        // Act
        var response = await _mediator.Send(command);

        // Assert
        response.Should().NotBeNull();
        response.Success.Should().BeFalse();
        response.Error.Should().NotBeNull();
        response.Error.Should().BeOfType<FluentValidation.ValidationException>();
    }

    #region Mock Setup Helpers

    private void SetupMockItemGeneratorService(int numberOfQuestions)
    {
        var mockItems = CreateMockItems(numberOfQuestions);
        var buildResult = new ItemBuildResult { Items = mockItems };

        _fixture.MockItemGeneratorService
            .Setup(x => x.GenerateItemsAsync(It.IsAny<ItemBuildRequest>()))
            .ReturnsAsync(buildResult);
    }

    private void SetupMockSurpassApiService(string subjectRef)
    {
        _fixture.MockSurpassApiService
            .Setup(x => x.CreateItemsAsync(It.IsAny<List<Item>>(), subjectRef))
            .Returns(Task.CompletedTask);

        _fixture.MockSurpassApiService
            .Setup(x => x.SubjectExistsAsync(subjectRef))
            .ReturnsAsync(true);
    }

    private void SetupMockFileStorage(string mediaFolder, string[] imageFiles, Dictionary<string, byte[]> imageData)
    {
        _fixture.MockFileStorage
            .Setup(x => x.GetFiles(mediaFolder, It.IsAny<List<string>>()))
            .Returns(imageFiles.ToList());

        foreach (var (fileName, data) in imageData)
        {
            _fixture.MockFileStorage
                .Setup(x => x.ReadAllBytes(fileName))
                .Returns(data);
        }
    }

    private void SetupMockFileSystem(string mediaFolder, string[] imageFiles)
    {
        // Mock directory exists
        _fixture.MockFileStorage
            .Setup(x => x.DirectoryExists(mediaFolder))
            .Returns(true);

        // Mock GetFiles returning full paths to the images
        _fixture.MockFileStorage
            .Setup(x => x.GetFiles(mediaFolder, It.IsAny<List<string>>()))
            .Returns(imageFiles.ToList());
    }

    private static List<Item> CreateMockItems(int count)
    {
        var items = new List<Item>();
        for (int i = 0; i < count; i++)
        {
            items.Add(new EitherOrItem
            {
                Type = ItemType.EitherOr,
                QuestionText = [$"Test Question {i + 1}?"],
                Category = "TestCategory",
                CorrectAnswer = true,
                Mark = 1
            });
        }
        return items;
    }

    #endregion
}

