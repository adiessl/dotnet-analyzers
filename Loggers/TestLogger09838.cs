using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09838 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09838>();

    public override int Id => 9838;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09838), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09838), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09838), Id);
        }
    }
}

