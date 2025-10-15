using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger09950 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger09950>();

    public override int Id => 9950;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger09950), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger09950), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger09950), Id);
        }
    }
}

