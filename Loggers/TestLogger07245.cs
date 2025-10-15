using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07245 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07245>();

    public override int Id => 7245;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07245), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07245), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07245), Id);
        }
    }
}

