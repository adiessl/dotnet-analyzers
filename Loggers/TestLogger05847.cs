using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05847 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05847>();

    public override int Id => 5847;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05847), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05847), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05847), Id);
        }
    }
}

