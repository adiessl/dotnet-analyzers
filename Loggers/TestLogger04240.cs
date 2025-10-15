using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04240 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04240>();

    public override int Id => 4240;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04240), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04240), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04240), Id);
        }
    }
}

