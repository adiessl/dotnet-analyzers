using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger02458 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger02458>();

    public override int Id => 2458;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger02458), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger02458), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger02458), Id);
        }
    }
}

