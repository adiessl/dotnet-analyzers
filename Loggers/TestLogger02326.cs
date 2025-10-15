using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger02326 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger02326>();

    public override int Id => 2326;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger02326), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger02326), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger02326), Id);
        }
    }
}

