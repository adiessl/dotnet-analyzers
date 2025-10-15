using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05709 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05709>();

    public override int Id => 5709;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05709), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05709), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05709), Id);
        }
    }
}

