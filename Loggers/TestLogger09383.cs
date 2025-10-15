using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09383 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09383>();

    public override int Id => 9383;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09383), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09383), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09383), Id);
        }
    }
}

