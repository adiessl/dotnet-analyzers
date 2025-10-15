using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05998 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05998>();

    public override int Id => 5998;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05998), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05998), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05998), Id);
        }
    }
}

