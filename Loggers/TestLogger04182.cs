using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04182 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04182>();

    public override int Id => 4182;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04182), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04182), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04182), Id);
        }
    }
}

