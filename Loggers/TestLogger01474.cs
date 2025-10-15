using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01474 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01474>();

    public override int Id => 1474;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01474), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01474), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01474), Id);
        }
    }
}

