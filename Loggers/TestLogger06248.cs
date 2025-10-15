using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06248 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06248>();

    public override int Id => 6248;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06248), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06248), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06248), Id);
        }
    }
}

