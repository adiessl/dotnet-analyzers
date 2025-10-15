using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09187 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09187>();

    public override int Id => 9187;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09187), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09187), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09187), Id);
        }
    }
}

