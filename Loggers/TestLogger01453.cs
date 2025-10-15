using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01453 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01453>();

    public override int Id => 1453;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01453), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01453), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01453), Id);
        }
    }
}

