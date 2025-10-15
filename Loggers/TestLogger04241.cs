using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04241 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04241>();

    public override int Id => 4241;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04241), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04241), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04241), Id);
        }
    }
}

