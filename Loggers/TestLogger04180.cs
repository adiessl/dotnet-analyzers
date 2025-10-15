using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04180 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04180>();

    public override int Id => 4180;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04180), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04180), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04180), Id);
        }
    }
}

