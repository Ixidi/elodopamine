using EloDopamine.Api.Game;
using EloDopamine.Application.Memory;

namespace EloDopamine.Application.Service;

public partial class GameService : IGameService
{
    private IGame? _game = null;

    public IGame Game
    {
        get
        {
            if (_game == null)
            {
                Update();
            }

            return _game!;
        }
    }

    private readonly int _baseAddress;
    private readonly IMemoryReader _memoryReader;

    public GameService(IMemoryReader memoryReader, int baseAddress)
    {
        _memoryReader = memoryReader;
        _baseAddress = baseAddress;
    }

    public void Update()
    {
        _game = ReadGame();
    }
}