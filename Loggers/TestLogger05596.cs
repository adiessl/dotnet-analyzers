using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger05596 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger05596>();

    public override int Id => 5596;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger05596), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger05596), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger05596), Id);
        }
    }
}

