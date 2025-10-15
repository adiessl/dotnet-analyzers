using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05746 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05746>();

    public override int Id => 5746;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05746), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05746), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05746), Id);
        }
    }
}

