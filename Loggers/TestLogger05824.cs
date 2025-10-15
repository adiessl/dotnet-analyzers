using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05824 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05824>();

    public override int Id => 5824;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05824), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05824), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05824), Id);
        }
    }
}

