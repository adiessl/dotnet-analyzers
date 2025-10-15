using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger08610 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger08610>();

    public override int Id => 8610;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger08610), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger08610), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger08610), Id);
        }
    }
}

