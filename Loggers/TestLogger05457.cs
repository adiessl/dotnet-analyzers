using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05457 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05457>();

    public override int Id => 5457;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05457), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05457), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05457), Id);
        }
    }
}

