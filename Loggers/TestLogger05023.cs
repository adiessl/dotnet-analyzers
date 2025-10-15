using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05023 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05023>();

    public override int Id => 5023;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05023), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05023), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05023), Id);
        }
    }
}

