using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06269 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06269>();

    public override int Id => 6269;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06269), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06269), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06269), Id);
        }
    }
}

