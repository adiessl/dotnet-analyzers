using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05734 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05734>();

    public override int Id => 5734;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05734), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05734), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05734), Id);
        }
    }
}

