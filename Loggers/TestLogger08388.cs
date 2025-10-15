using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger08388 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger08388>();

    public override int Id => 8388;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger08388), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger08388), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger08388), Id);
        }
    }
}

