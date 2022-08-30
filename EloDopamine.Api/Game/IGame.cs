using EloDopamine.Api.Math;

namespace EloDopamine.Api.Game;

public interface IGame
{
    float GameTime { get; }
    float WindowHeight { get; }
    float WindowWidth { get; }
    bool IsWindowFocused { get; }
    bool IsChatOpen { get; }
    IVector3 MousePosition { get; }

    IVector2? WorldToScreen(IVector3 vec);
}