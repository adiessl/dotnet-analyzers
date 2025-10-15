using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07270 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07270>();

    public override int Id => 7270;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07270), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07270), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07270), Id);
        }
    }
}

