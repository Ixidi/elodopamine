using EloDopamine.Api.Game;
using EloDopamine.Api.Math;

namespace EloDopamine.Application.Game;

public class Game : IGame
{
    public float GameTime { get; }
    public float WindowHeight { get; }
    public float WindowWidth { get; }
    public bool IsWindowFocused { get; }
    public bool IsChatOpen { get; }
    public IVector3 MousePosition { get; }

    private readonly float[] _viewProjectionMatrix;

    public Game(float gameTime, float windowHeight, float windowWidth, bool isWindowFocused, bool isChatOpen,
        IVector3 mousePosition, float[] viewProjectionMatrix)
    {
        GameTime = gameTime;
        WindowHeight = windowHeight;
        WindowWidth = windowWidth;
        IsWindowFocused = isWindowFocused;
        IsChatOpen = isChatOpen;
        MousePosition = mousePosition;
        
        if (viewProjectionMatrix.Length != 16)
        {
            throw new ArgumentException("viewProjectionMatrix must be 4x4 matrix.");
        }

        _viewProjectionMatrix = viewProjectionMatrix;
    }

    public IVector2? WorldToScreen(IVector3 vec)
    {
        var clipCoordsX = vec.X * _viewProjectionMatrix[0] + vec.Y * _viewProjectionMatrix[4] +
                            vec.Z * _viewProjectionMatrix[8] + _viewProjectionMatrix[12];
        var clipCoordsY = vec.X * _viewProjectionMatrix[1] + vec.Y * _viewProjectionMatrix[5] +
                            vec.Z * _viewProjectionMatrix[9] + _viewProjectionMatrix[13];
        var clipCoordsW = vec.X * _viewProjectionMatrix[3] + vec.Y * _viewProjectionMatrix[7] +
                            vec.Z * _viewProjectionMatrix[11] + _viewProjectionMatrix[15];

        if (clipCoordsW < 0.1)
        {
            return null;
        }

        var mX = clipCoordsX / clipCoordsW;
        var mY = clipCoordsY / clipCoordsW;

        var outX = (WindowWidth / 2 * mX) + (mX + WindowWidth / 2);
        var outY = -(WindowHeight / 2 * mY) + (mY + WindowHeight / 2);

        return new Vector2(outX, outY);
    }
}