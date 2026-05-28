using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace SurpassDataPopulator.Domain.Common.Telemetry;

public static class TelemetryConfig
{
    public const string ServiceName = "SurpassDataPopulator";

    public static readonly Meter Meter = new(ServiceName);
    public static readonly ActivitySource Activity = new(ServiceName, typeof(TelemetryConfig).Assembly.GetName().Version?.ToString());
}