using EloDopamine.Api.Game;
using EloDopamine.Api.Math;

namespace EloDopamine.Application.Game;

public class Game : IGame
{
    public float GameTime { get; }
    public bool IsChatOpen { get; }
    public IGameWindow Window { get; }
    public IGameEntities Entities { get; }

    private readonly float[] _viewProjectionMatrix;

    public Game(float gameTime, bool isChatOpen, IGameWindow window, IGameEntities entities,
        float[] viewProjectionMatrix)
    {
        GameTime = gameTime;
        IsChatOpen = isChatOpen;
        Window = window;
        Entities = entities;
        if (viewProjectionMatrix.Length != 16)
        {
            throw new ArgumentException($"{nameof(viewProjectionMatrix)} is not 4x4 matrix.");
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

        var outX = (Window.Width / 2 * mX) + (mX + Window.Width / 2);
        var outY = -(Window.Height / 2 * mY) + (mY + Window.Height / 2);

        return new Vector2(outX, outY);
    }
}