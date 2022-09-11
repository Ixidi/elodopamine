using EloDopamine.Api.Game;
using EloDopamine.Application.Game;
using EloDopamine.Application.Memory;

namespace EloDopamine.Application.Service;

public partial class GameService
{
    private int? _renderAddress;
    private int? _hudAddress;
    private IGameWindow ReadWindow()
    {
        var renderAddress = GetRenderAddress();
        var hudAddress = GetHudAddress();
        
        return new GameWindow(
            height: _memoryReader.ReadInt(renderAddress + Offsets.GameWindowHeight),
            width: _memoryReader.ReadInt(renderAddress + Offsets.GameWindowWidth),
            isFocused: _memoryReader.ReadInt(hudAddress + Offsets.HudIsFocused) == 1,
            mousePosition: _memoryReader.ReadVector(hudAddress + Offsets.HudMouseWorldPosition)
        );
    }

    private int GetRenderAddress()
    {
        _renderAddress ??= _memoryReader.ReadInt(_baseAddress + Offsets.Renderer);

        return _renderAddress.Value;
    }
    
    private int GetHudAddress()
    {
        _hudAddress ??= _memoryReader.ReadInt(_baseAddress + Offsets.HudInterface);

        return _hudAddress.Value;
    }
}