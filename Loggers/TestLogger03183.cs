using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger03183 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger03183>();

    public override int Id => 3183;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger03183), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger03183), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger03183), Id);
        }
    }
}

