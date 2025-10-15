using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger08613 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger08613>();

    public override int Id => 8613;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger08613), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger08613), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger08613), Id);
        }
    }
}

