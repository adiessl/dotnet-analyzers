using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger02979 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger02979>();

    public override int Id => 2979;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger02979), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger02979), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger02979), Id);
        }
    }
}

