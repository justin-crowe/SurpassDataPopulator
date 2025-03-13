using System.Reflection;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SurpassDataPopulator.Application.Common.Behaviours;
using SurpassDataPopulator.Domain.Data.Builders.Items;
using SurpassDataPopulator.Domain.Data.Builders.Items.Adaptive;
using SurpassDataPopulator.Domain.Data.Builders.ItemTags;

namespace SurpassDataPopulator.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services
            .AddAutoMapper(Assembly.GetExecutingAssembly())
            .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly())
            .AddMediatR(Assembly.GetExecutingAssembly())
            .AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>))
            .AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>))
            .AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>))

            .AddTransient<IAdaptiveItemBuilder, AdaptiveItemBuilder>()
            .AddTransient<ITagApplicator, TagApplicator>()
            .AddTransient<IItemBuilder, ItemBuilder>();

        return services;
    }
}