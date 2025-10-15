using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01188 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01188>();

    public override int Id => 1188;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01188), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01188), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01188), Id);
        }
    }
}

