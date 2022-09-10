using System.Diagnostics;
using EloDopamine.Application.Memory;
using EloDopamine.Application.Service;

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
        var process = Process.GetProcessesByName("League of Legends").First();
        var memoryReader = new MemoryReader(process);
        var gameService = new GameService(memoryReader, process.MainModule!.BaseAddress.ToInt32());
        gameService.Update();
        Console.WriteLine(gameService.Game.Window.Height);
    }
    
}