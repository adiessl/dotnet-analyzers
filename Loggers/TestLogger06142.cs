using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06142 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06142>();

    public override int Id => 6142;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06142), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06142), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06142), Id);
        }
    }
}

