using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04006 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04006>();

    public override int Id => 4006;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04006), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04006), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04006), Id);
        }
    }
}

