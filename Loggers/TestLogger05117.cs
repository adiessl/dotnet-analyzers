using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05117 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05117>();

    public override int Id => 5117;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05117), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05117), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05117), Id);
        }
    }
}

