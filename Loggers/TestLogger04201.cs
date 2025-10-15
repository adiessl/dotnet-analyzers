using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04201 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04201>();

    public override int Id => 4201;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04201), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04201), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04201), Id);
        }
    }
}

