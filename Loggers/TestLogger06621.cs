using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06621 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06621>();

    public override int Id => 6621;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06621), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06621), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06621), Id);
        }
    }
}

