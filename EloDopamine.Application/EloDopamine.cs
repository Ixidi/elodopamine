using System.Diagnostics;
using EloDopamine.Application.Memory;
using EloDopamine.Application.Service;
using log4net;
using log4net.Core;

namespace EloDopamine.Application;

public class EloDopamine
{

    private static readonly ILog Log = LogManager.GetLogger(typeof(EloDopamine));
    
    public void Start()
    {
        log4net.Config.BasicConfigurator.Configure();
        
        Log.Info("Starting application...");
        var process = Process.GetProcessesByName("League of Legends").First();
        var memoryReader = new MemoryReader(process);
        var gameService = new GameService(memoryReader, process.MainModule!.BaseAddress.ToInt32());
        gameService.Update();
        Log.Info(gameService.Game.Entities.LocalPlayer.SpellBook.Q.Level);
        Log.Info(gameService.Game.Entities.LocalPlayer.SpellBook.W.Name);
        Log.Info(gameService.Game.Entities.LocalPlayer.Name);
    }
    
}