using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01040 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01040>();

    public override int Id => 1040;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01040), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01040), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01040), Id);
        }
    }
}

