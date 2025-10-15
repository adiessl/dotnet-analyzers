using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger08162 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger08162>();

    public override int Id => 8162;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger08162), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger08162), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger08162), Id);
        }
    }
}

