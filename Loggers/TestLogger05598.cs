using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05598 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05598>();

    public override int Id => 5598;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05598), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05598), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05598), Id);
        }
    }
}

