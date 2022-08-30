using EloDopamine.Api.Game;
using EloDopamine.Application.Memory;

namespace EloDopamine.Application.Game;

public class GameService : IGameService
{
    private IGameManager? _gameManager = null;

    public IGameManager GameManager
    {
        get
        {
            if (_gameManager == null)
            {
                Update();
            }

            return _gameManager ?? ReadGameManager();
        }
    }

    private readonly int _baseAddress;
    private readonly IMemoryReader _memoryReader;

    public GameService(int baseAddress, IMemoryReader memoryReader)
    {
        _baseAddress = baseAddress;
        _memoryReader = memoryReader;
    }

    public void Update()
    {
        _gameManager = ReadGameManager();
    }

    private IGameManager ReadGameManager()
    {
    }

    public IHero ReadHero(int address)
    {
        var buffBytes = _memoryReader.ReadBytes(address, 30_000);
        var reader = new ByteReader(buffBytes);
        var gameObject = ReadGameObject(reader, address);

        var spell = new Spell("", 0f, 1);
        var spellBook = new SpellBook(spell, spell, spell, spell, spell, spell);
        //TODO read
        
        return new Hero(
            name: gameObject.Name,
            position: gameObject.Position,
            team: gameObject.Team,
            health: gameObject.Health,
            isVisible: gameObject.IsVisible,
            attackRange: gameObject.AttackRange,
            spellBook: spellBook,
            
        );
    }
    
    public ISpellBook Read

    private IGameObject ReadGameObject(IReader reader, int address)
    {
        var teamCode = reader.ReadInt(address + Offsets.OBJECT_TEAM);
        var team = teamCode switch
        {
            100 => Team.Blue,
            200 => Team.Red,
            _ => Team.Unknown
        };

        return new GameObject(
            name: _memoryReader.ReadString(address + Offsets.OBJECT_CHAMPION_NAME),
            position: reader.ReadVector(Offsets.OBJECT_POSITION),
            team: team,
            health: reader.ReadFloat(Offsets.OBJECT_HEALTH),
            isVisible: reader.ReadBool(Offsets.OBJECT_VISIBILITY),
            attackRange: reader.ReadFloat(Offsets.OBJECT_ATTACK_RANGE)
        );
    }
}