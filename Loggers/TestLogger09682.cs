using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09682 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09682>();

    public override int Id => 9682;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09682), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09682), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09682), Id);
        }
    }
}

