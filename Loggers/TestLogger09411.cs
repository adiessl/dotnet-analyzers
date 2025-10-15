using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09411 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09411>();

    public override int Id => 9411;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09411), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09411), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09411), Id);
        }
    }
}

