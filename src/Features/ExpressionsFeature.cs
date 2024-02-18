using Volte.Expressions.Contracts;
using Volte.Expressions.Services;
using Volte.Features.Abstractions;
using Volte.Features.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Volte.Expressions.Features;

/// <summary>
/// Installs and configures the expressions feature.
/// </summary>
public class ExpressionsFeature : FeatureBase
{
    /// <inheritdoc />
    public ExpressionsFeature(IModule module) : base(module)
    {
    }

    /// <inheritdoc />
    public override void Configure()
    {
        Services
            .AddScoped<IExpressionEvaluator, ExpressionEvaluator>()
            .AddSingleton<IWellKnownTypeRegistry, WellKnownTypeRegistry>();
    }
}