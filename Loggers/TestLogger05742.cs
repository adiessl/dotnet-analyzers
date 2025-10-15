using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05742 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05742>();

    public override int Id => 5742;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05742), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05742), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05742), Id);
        }
    }
}

