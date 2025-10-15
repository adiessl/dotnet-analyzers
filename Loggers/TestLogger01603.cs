using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01603 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01603>();

    public override int Id => 1603;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01603), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01603), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01603), Id);
        }
    }
}

