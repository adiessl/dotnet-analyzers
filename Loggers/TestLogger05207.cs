using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05207 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05207>();

    public override int Id => 5207;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05207), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05207), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05207), Id);
        }
    }
}

