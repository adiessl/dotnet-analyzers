using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05775 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05775>();

    public override int Id => 5775;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05775), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05775), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05775), Id);
        }
    }
}

