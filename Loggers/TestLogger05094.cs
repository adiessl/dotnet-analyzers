using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05094 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05094>();

    public override int Id => 5094;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05094), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05094), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05094), Id);
        }
    }
}

