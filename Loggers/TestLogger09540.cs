using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09540 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09540>();

    public override int Id => 9540;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09540), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09540), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09540), Id);
        }
    }
}

