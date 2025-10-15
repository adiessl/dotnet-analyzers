using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06002 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06002>();

    public override int Id => 6002;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06002), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06002), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06002), Id);
        }
    }
}

