using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger00041 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger00041>();

    public override int Id => 41;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger00041), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger00041), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger00041), Id);
        }
    }
}

