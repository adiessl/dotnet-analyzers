using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger04920 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger04920>();

    public override int Id => 4920;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger04920), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger04920), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger04920), Id);
        }
    }
}

