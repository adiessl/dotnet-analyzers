using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03133 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03133>();

    public override int Id => 3133;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03133), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03133), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03133), Id);
        }
    }
}

