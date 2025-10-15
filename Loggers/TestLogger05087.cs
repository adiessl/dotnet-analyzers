using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05087 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05087>();

    public override int Id => 5087;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05087), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05087), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05087), Id);
        }
    }
}

