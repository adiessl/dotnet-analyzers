using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05913 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05913>();

    public override int Id => 5913;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05913), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05913), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05913), Id);
        }
    }
}

