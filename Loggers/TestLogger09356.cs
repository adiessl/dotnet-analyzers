using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09356 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09356>();

    public override int Id => 9356;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09356), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09356), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09356), Id);
        }
    }
}

