using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07121 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07121>();

    public override int Id => 7121;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07121), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07121), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07121), Id);
        }
    }
}

