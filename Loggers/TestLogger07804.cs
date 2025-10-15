using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07804 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07804>();

    public override int Id => 7804;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07804), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07804), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07804), Id);
        }
    }
}

