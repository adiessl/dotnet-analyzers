using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger08131 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger08131>();

    public override int Id => 8131;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger08131), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger08131), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger08131), Id);
        }
    }
}

