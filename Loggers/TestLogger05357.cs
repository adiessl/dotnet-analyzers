using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05357 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05357>();

    public override int Id => 5357;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05357), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05357), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05357), Id);
        }
    }
}

