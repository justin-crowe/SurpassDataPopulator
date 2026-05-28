using System.Reflection;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SurpassDataPopulator.Application.Common.Behaviours;
using SurpassDataPopulator.Application.Common.Progress;
using SurpassDataPopulator.Domain.Data.Builders.Items;
using SurpassDataPopulator.Domain.Data.Builders.Items.Adaptive;
using SurpassDataPopulator.Domain.Data.Builders.ItemTags;

namespace SurpassDataPopulator.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services
            .AddAutoMapper(x => x.AddMaps(Assembly.GetExecutingAssembly()))
            .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly())
            .AddMediatR( x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()))
            .AddTransient(typeof(IPipelineBehavior<,>), typeof(ObservabilityBehaviour<,>))
            .AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>))

            .AddScoped<IProgressContext, ProgressContext>()

            .AddTransient<IAdaptiveItemBuilder, AdaptiveItemBuilder>()
            .AddTransient<ITagApplicator, TagApplicator>()
            .AddTransient<IItemBuilder, ItemBuilder>();

        return services;
    }
}