using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06855 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06855>();

    public override int Id => 6855;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06855), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06855), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06855), Id);
        }
    }
}

