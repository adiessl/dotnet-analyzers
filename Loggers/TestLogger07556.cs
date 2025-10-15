using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07556 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07556>();

    public override int Id => 7556;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07556), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07556), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07556), Id);
        }
    }
}

