using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07457 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07457>();

    public override int Id => 7457;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07457), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07457), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07457), Id);
        }
    }
}

