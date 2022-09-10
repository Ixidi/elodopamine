using EloDopamine.Api.Math;

namespace EloDopamine.Api.Game;

public interface IGameWindow
{
    float Height { get; }
    float Width { get; }
    bool IsFocused { get; }
    IVector3 MousePosition { get; }
}