using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01563 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01563>();

    public override int Id => 1563;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01563), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01563), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01563), Id);
        }
    }
}

