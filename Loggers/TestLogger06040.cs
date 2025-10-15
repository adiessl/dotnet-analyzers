using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06040 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06040>();

    public override int Id => 6040;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06040), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06040), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06040), Id);
        }
    }
}

