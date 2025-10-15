using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07212 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07212>();

    public override int Id => 7212;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07212), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07212), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07212), Id);
        }
    }
}

