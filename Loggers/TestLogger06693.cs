using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger06693 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger06693>();

    public override int Id => 6693;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger06693), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger06693), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger06693), Id);
        }
    }
}

