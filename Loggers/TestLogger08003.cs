using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger08003 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger08003>();

    public override int Id => 8003;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger08003), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger08003), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger08003), Id);
        }
    }
}

