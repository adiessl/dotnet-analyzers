using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09567 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09567>();

    public override int Id => 9567;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09567), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09567), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09567), Id);
        }
    }
}

