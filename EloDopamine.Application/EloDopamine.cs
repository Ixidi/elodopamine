namespace EloDopamine.Application;

public class EloDopamine
{

    private ILogger _logger { get; }

    public EloDopamine(ILogger logger)
    {
        _logger = logger;
    }

    public void Start()
    {
        _logger.Info("Starting application...");
    }
    
}