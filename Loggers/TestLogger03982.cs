using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03982 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03982>();

    public override int Id => 3982;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03982), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03982), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03982), Id);
        }
    }
}

