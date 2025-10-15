using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04509 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04509>();

    public override int Id => 4509;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04509), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04509), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04509), Id);
        }
    }
}

