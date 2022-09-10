namespace EloDopamine.Application;

public class ConsoleLogger : ILogger
{
    public void Info(object any)
    {
        Console.WriteLine(any);
    }
    
}