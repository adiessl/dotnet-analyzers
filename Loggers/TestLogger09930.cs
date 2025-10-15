using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09930 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09930>();

    public override int Id => 9930;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09930), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09930), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09930), Id);
        }
    }
}

