using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger07241 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger07241>();

    public override int Id => 7241;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger07241), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger07241), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger07241), Id);
        }
    }
}

