using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07428 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07428>();

    public override int Id => 7428;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07428), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07428), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07428), Id);
        }
    }
}

