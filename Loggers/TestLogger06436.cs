using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06436 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06436>();

    public override int Id => 6436;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06436), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06436), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06436), Id);
        }
    }
}

