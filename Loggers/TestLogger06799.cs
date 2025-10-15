using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06799 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06799>();

    public override int Id => 6799;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06799), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06799), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06799), Id);
        }
    }
}

