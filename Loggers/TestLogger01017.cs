using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger01017 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger01017>();

    public override int Id => 1017;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger01017), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger01017), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger01017), Id);
        }
    }
}

