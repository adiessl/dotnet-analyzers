using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07906 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07906>();

    public override int Id => 7906;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07906), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07906), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07906), Id);
        }
    }
}

