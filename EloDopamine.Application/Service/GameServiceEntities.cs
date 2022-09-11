using EloDopamine.Api.Game;
using EloDopamine.Api.Math;
using EloDopamine.Application.Game;
using EloDopamine.Application.Memory;
using log4net.Core;

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

	private ISpell ReadSpell(int address)
	{
		var bytes = _memoryReader.ReadBytes(address, 500);
		var buff = new ByteReader(bytes);
		var readyAt = buff.ReadFloat(Offsets.SpellReadyAt);
		var lvl = buff.ReadInt(Offsets.SpellLevel);
		var spellInfo = buff.ReadInt(Offsets.SpellInfo);
		var spellName = _memoryReader.ReadString(spellInfo + Offsets.SpellName);
		Console.WriteLine(spellName);
		return new Spell(
			name: spellName,
			readyAt: readyAt,
			level: lvl
		);
	}

	private ISpellBook ReadSpellBook(IReader buff)
	{
		var spellSlotQ = buff.ReadInt(Offsets.ObjectSpellBook);
		var spellSlotW = buff.ReadInt(Offsets.ObjectSpellBook + 4);
		var spellSlotE = buff.ReadInt(Offsets.ObjectSpellBook + 8);
		var spellSlotR = buff.ReadInt(Offsets.ObjectSpellBook + 12);
		var spellSlotFirstSummonerSpell = buff.ReadInt(Offsets.ObjectSpellBook + 16);
		var spellSlotSecondSummonerSpell = buff.ReadInt(Offsets.ObjectSpellBook + 20);
		
		
		return new SpellBook(
			q: ReadSpell(spellSlotQ),
			w: ReadSpell(spellSlotW),
			e: ReadSpell(spellSlotE),
			r: ReadSpell(spellSlotR),
			firstSummonerSpell: ReadSpell(spellSlotFirstSummonerSpell),
			secondSummonerSpell: ReadSpell(spellSlotSecondSummonerSpell)
		);
	}

	private IHero ReadHero(int address)
	{
		var localPlayerAddress = _memoryReader.ReadInt(address);
		var bytes = _memoryReader.ReadBytes(localPlayerAddress, 30_000);
		var gameObjectBuff = new ByteReader(bytes);
		var gameObject = ReadGameObject(gameObjectBuff, localPlayerAddress);


		var spellBook = ReadSpellBook(gameObjectBuff);

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