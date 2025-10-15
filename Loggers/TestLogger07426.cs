using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07426 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07426>();

    public override int Id => 7426;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07426), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07426), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07426), Id);
        }
    }
}

