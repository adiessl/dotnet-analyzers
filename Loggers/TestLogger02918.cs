using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger02918 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger02918>();

    public override int Id => 2918;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger02918), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger02918), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger02918), Id);
        }
    }
}

