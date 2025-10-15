using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger02607 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger02607>();

    public override int Id => 2607;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger02607), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger02607), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger02607), Id);
        }
    }
}

