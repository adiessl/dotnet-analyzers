using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger02000 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger02000>();

    public override int Id => 2000;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger02000), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger02000), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger02000), Id);
        }
    }
}

