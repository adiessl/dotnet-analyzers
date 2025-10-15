using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09262 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09262>();

    public override int Id => 9262;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09262), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09262), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09262), Id);
        }
    }
}

