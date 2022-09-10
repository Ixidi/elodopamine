using EloDopamine.Api.Math;

namespace EloDopamine.Api.Game;

public interface IGame
{
    float GameTime { get; }
    bool IsChatOpen { get; }
    IGameWindow Window { get; }
    IGameEntities Entities { get; }
    IVector2? WorldToScreen(IVector3 vec);
}