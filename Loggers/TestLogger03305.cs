using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03305 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03305>();

    public override int Id => 3305;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03305), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03305), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03305), Id);
        }
    }
}

