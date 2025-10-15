using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05701 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05701>();

    public override int Id => 5701;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05701), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05701), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05701), Id);
        }
    }
}

