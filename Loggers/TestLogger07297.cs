using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07297 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07297>();

    public override int Id => 7297;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07297), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07297), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07297), Id);
        }
    }
}

