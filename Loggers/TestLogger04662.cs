using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04662 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04662>();

    public override int Id => 4662;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04662), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04662), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04662), Id);
        }
    }
}

