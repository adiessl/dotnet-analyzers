using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05055 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05055>();

    public override int Id => 5055;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05055), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05055), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05055), Id);
        }
    }
}

