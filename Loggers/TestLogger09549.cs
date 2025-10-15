using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09549 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09549>();

    public override int Id => 9549;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09549), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09549), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09549), Id);
        }
    }
}

