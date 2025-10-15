using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05562 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05562>();

    public override int Id => 5562;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05562), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05562), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05562), Id);
        }
    }
}

