using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07325 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07325>();

    public override int Id => 7325;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07325), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07325), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07325), Id);
        }
    }
}

