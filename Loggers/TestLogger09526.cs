using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09526 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09526>();

    public override int Id => 9526;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09526), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09526), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09526), Id);
        }
    }
}

