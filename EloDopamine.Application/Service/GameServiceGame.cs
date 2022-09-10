using EloDopamine.Api.Game;
using EloDopamine.Application.Memory;
using EloDopamine.Application.Utils;

namespace EloDopamine.Application.Service;

public partial class GameService
{
    private IGame ReadGame()
    {
        var window = ReadWindow();
        var entities = ReadEntities();
        
        var viewProjectionMatrixBytes = _memoryReader.ReadBytes(_baseAddress + Offsets.ViewProjMatrices, 16 * 8);
        var viewProjectionMatrixBuff = new ByteReader(viewProjectionMatrixBytes);
        var viewMatrix = new float[16];
        var projectionMatrix = new float[16];
        for (var i = 0; i < 16; i++)
        {
            viewMatrix[i] = viewProjectionMatrixBuff.ReadFloat(i * 4);
            projectionMatrix[i] = viewProjectionMatrixBuff.ReadFloat((16 * 4) + (i * 4));
        }

        var viewProjectionMatrix = MatrixUtils.Multiply4X4Matrices(viewMatrix, projectionMatrix);
        
        return new Game.Game(
            gameTime: _memoryReader.ReadFloat(_baseAddress + Offsets.GameTime),
            isChatOpen: false, //TODO missing offset
            window: window,
            entities: entities,
            viewProjectionMatrix: viewProjectionMatrix
        );
    }
}