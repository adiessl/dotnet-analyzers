using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06581 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06581>();

    public override int Id => 6581;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06581), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06581), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06581), Id);
        }
    }
}

