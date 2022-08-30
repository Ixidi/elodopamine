using EloDopamine.Api.Draw;
using EloDopamine.Api.Game;

namespace EloDopamine.Api.Plugin;

public interface IPlugin
{
    string Name { get; }
    string Description { get; }
    string Version { get; }

    void OnPluginRegister(IPluginRegistration registration);
    void OnPluginEnable();
    void OnPluginDisable();
    void OnFrameUpdate(IDrawer drawer, IGameManager gameManager);
}