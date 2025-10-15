using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05077 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05077>();

    public override int Id => 5077;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05077), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05077), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05077), Id);
        }
    }
}

