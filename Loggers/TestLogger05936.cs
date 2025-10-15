using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05936 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05936>();

    public override int Id => 5936;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05936), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05936), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05936), Id);
        }
    }
}

