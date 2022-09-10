using EloDopamine.Api.Game;
using EloDopamine.Api.Math;

namespace EloDopamine.Application.Game;

public class GameWindow : IGameWindow
{
    public float Height { get; }
    public float Width { get; }
    public bool IsFocused { get; }
    public IVector3 MousePosition { get; }

    public GameWindow(float height, float width, bool isFocused, IVector3 mousePosition)
    {
        Height = height;
        Width = width;
        IsFocused = isFocused;
        MousePosition = mousePosition;
    }
}