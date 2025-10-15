using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger02162 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger02162>();

    public override int Id => 2162;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger02162), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger02162), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger02162), Id);
        }
    }
}

