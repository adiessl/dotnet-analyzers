using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05801 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05801>();

    public override int Id => 5801;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05801), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05801), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05801), Id);
        }
    }
}

