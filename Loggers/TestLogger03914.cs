using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03914 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03914>();

    public override int Id => 3914;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03914), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03914), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03914), Id);
        }
    }
}

