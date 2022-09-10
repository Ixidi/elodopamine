using EloDopamine.Api.Game;
using EloDopamine.Api.Math;
using EloDopamine.Application.Game;
using EloDopamine.Application.Memory;

namespace EloDopamine.Application.Service;

public partial class GameService
{
    private IGameEntities ReadEntities()
    {
        var localPlayer = ReadHero(_baseAddress + Offsets.LocalPlayer);
        return new GameEntities(
            localPlayer: localPlayer,
            heroes: new List<IHero>(),
            allMinions: new List<IMinion>(),
            enemyMinions: new List<IMinion>(),
            allyMinion: new List<IMinion>(),
            missiles: new List<IMissile>()
        );
    }

    private IHero ReadHero(int address)
    {
        var localPlayerAddress = _memoryReader.ReadInt(address);
        var bytes = _memoryReader.ReadBytes(localPlayerAddress, 30_000);
        var gameObjectBuff = new ByteReader(bytes);
        var gameObject = ReadGameObject(gameObjectBuff, localPlayerAddress);

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
            navigationArray: Array.Empty<IVector3>(),
            movementSpeed: gameObjectBuff.ReadFloat(Offsets.ObjectMovementSpeed),
            isMoving: true,
            isDashing: true
        );
    }

    private IGameObject ReadGameObject(IReader buffer, int address)
    {
        var teamCode = buffer.ReadInt(Offsets.ObjectTeam);
        var team = teamCode switch
        {
            100 => Team.Blue,
            200 => Team.Red,
            _ => Team.Unknown
        };

        return new GameObject(
            name: _memoryReader.ReadString(address + Offsets.ObjectChampionName),
            position: buffer.ReadVector(Offsets.ObjectPosition),
            team: team,
            health: buffer.ReadFloat(Offsets.ObjectHealth),
            isVisible: buffer.ReadBool(Offsets.ObjectVisibility),
            attackRange: buffer.ReadFloat(Offsets.ObjectAttackRange)
        );
    }
}