using EloDopamine.Api.Game;
using EloDopamine.Api.Math;
using EloDopamine.Application.Game;
using EloDopamine.Application.Memory;

namespace EloDopamine.Application.Service;

public partial class GameService
{

    private IGameWindow ReadWindow()
    {
        return new GameWindow(
            height: _memoryReader.ReadFloat(_baseAddress + Offsets.GameWindowHeight),
            width: _memoryReader.ReadFloat(_baseAddress + Offsets.GameWindowWidth),
            isFocused: true, //TODO missing offset
            mousePosition: new Vector3(0, 0, 0) //TODO missing offset
        );
    }
}