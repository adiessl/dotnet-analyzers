using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05568 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05568>();

    public override int Id => 5568;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05568), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05568), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05568), Id);
        }
    }
}

