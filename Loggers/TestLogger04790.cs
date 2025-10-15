using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04790 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04790>();

    public override int Id => 4790;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04790), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04790), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04790), Id);
        }
    }
}

