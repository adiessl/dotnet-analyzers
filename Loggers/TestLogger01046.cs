using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01046 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01046>();

    public override int Id => 1046;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01046), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01046), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01046), Id);
        }
    }
}

