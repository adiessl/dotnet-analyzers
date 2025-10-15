using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04415 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04415>();

    public override int Id => 4415;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04415), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04415), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04415), Id);
        }
    }
}

