using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger10000 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger10000>();

    public override int Id => 10000;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger10000), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger10000), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger10000), Id);
        }
    }
}

