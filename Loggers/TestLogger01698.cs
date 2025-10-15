using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01698 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01698>();

    public override int Id => 1698;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01698), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01698), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01698), Id);
        }
    }
}

