using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07130 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07130>();

    public override int Id => 7130;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07130), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07130), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07130), Id);
        }
    }
}

