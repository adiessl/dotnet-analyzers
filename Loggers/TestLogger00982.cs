using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger00982 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger00982>();

    public override int Id => 982;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger00982), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger00982), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger00982), Id);
        }
    }
}

