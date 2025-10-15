using Serilog;

namespace Common.Loggers;

internal sealed class TestLogger08085 : TestLogger
{
    private static readonly ILogger Logger = Serilog.Log.ForContext<TestLogger08085>();

    public override int Id => 8085;

    public override void Log()
    {
        if (Id % 1000 == 0)
        {
            Logger.Information("Hello from {Logger} with ID {Id}", nameof(TestLogger08085), Id);
        }
        else if (Id % 100 == 0)
        {
            Logger.Debug("Hello from {Logger} with ID {Id}", nameof(TestLogger08085), Id);
        }
        else
        {
            Logger.Verbose("Hello from {Logger} with ID {Id}", nameof(TestLogger08085), Id);
        }
    }
}

