using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01703 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01703>();

    public override int Id => 1703;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01703), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01703), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01703), Id);
        }
    }
}

