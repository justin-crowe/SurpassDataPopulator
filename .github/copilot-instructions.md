# SurpassDataPopulator Copilot Instructions

## Project Overview
A .NET console application for populating Surpass assessment platform instances with test data. Uses Clean Architecture with CQRS/MediatR pattern, integrating with Surpass API and Open Trivia Api for generating assessment items.

## Architecture Pattern
Follow **Clean Architecture** with these layers:
- **Console**: Entry point with System.CommandLine for CLI verbs (`createItems`, `createAdaptiveItems`, etc.)
- **Application**: CQRS commands/handlers using MediatR, validation with FluentValidation and request pipeline behaviors
- **Domain**: Business logic, builders, entities (no external dependencies)
- **Infrastructure**: External integrations (Surpass API SDK, OpenTrivia API, file storage)

Separation between layers is strict; no reference to console in any other layer so that the core logic is reusable in another host type if needed.

## Key Development Patterns

### Console Command Structure
Console Commands follow this pattern in `Console/Cli/Verbs/`:
```csharp
public class CreateItems : Command
{
    public CreateItems(MediatrBinder mediatorBinder) : base()
    {
        Name = "createItems";
        // Define options with validation
        // Bind to MediatR command via SetHandler
    }
}
```

### MediatR Pipeline
All operations use MediatR with pipeline behaviors:
- `ValidationBehaviour<,>`: FluentValidation automatic validation
- `ObservabilityBehaviour<,>`: Logging and telemetry
- Commands implement `IRequest` with corresponding `IRequestHandler<>`

### Authentication Flow
Authentication is stateful via `ICredentialsStore`:
1. Run `login` command first to authenticate with Surpass API
2. Credentials stored in session for subsequent operations
3. URL normalization: auto-adds `/api/v2` suffix and `https://` prefix

### Configuration Management
- `appsettings.json` for base config (Serilog, API URLs)
- **Required**: Set `SurpassApi.BaseUrl`, `SurpassApi.Username`, `SurpassApi.Password`
- Development overrides via `appsettings.Development.json`
- OpenTrivia API configured for question generation
- **Use Options Pattern**: Configure services with `IOptions<T>` for strongly-typed configuration classes

## Domain-Specific Conventions

### Item Building Pattern
Use builder pattern in `Domain/Data/Builders/`:
```csharp
IItemBuilder.AddItemContent(ItemBuildResult, ItemImageRequest)
IAdaptiveItemBuilder // Extends with adaptive-specific tagging
ITagApplicator // Handles tag assignment patterns
```

### Media Handling
- Images loaded from `--mediaFolder` parameter into memory dictionary
- Random assignment via `ThreadSafeRandom` for consistent randomization
- Supported formats: jpg, jpeg, png, gif, bmp, tiff, svg

### Data Sources Integration
- **OpenTrivia API**: Categories map to trivia question types (see `IOpenTriviaApi.cs`)
- **Surpass API**: Custom SDK in separate project `SurpassDataPopulator.Infrastructure.SurpassApiSdk`
- Category numbers correspond to OpenTrivia database categories

## Essential Commands

### Build & Run
```bash
# Build solution
dotnet build src/SurpassDataPopulator.sln

# Run with authentication
dotnet run --project src/SurpassDataPopulator.Console -- login -u username -p password -url https://instance.surpass.com
dotnet run --project src/SurpassDataPopulator.Console -- createAdaptiveItems -s "SUBJECT_REF" -n 100
```

### Common Workflows
1. **Setup**: Configure `appsettings.json` → Build → Login
2. **Item Creation**: Use `createItems` or `createAdaptiveItems` verbs
3. **Media Integration**: Use `--mediaFolder` for images, `--mediaItems` for random counts
4. **Variants**: Use `--variants en fr` for language variants in adaptive items

## Debugging Patterns
- Serilog configured with console + file logging (`Logs/log.txt`)
- Use `--showCorrect` flag to include answers in item stems for debugging
- FluentValidation errors automatically logged via pipeline behavior
- Structured logging with request/response correlation

## External Dependencies
- **Surpass API**: Assessment platform REST API (custom SDK)
- **OpenTrivia API**: Free trivia questions API for content generation
- **System.CommandLine**: Modern CLI framework (not legacy args parsing)
- **AutoMapper**: DTO/Entity mapping in Application layer
- **Serilog**: Structured logging with multiple sinks

When adding features, maintain the Clean Architecture boundaries, use MediatR for all operations, and follow the established builder patterns for data construction.