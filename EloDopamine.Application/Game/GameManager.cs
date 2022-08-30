using EloDopamine.Api.Game;

namespace EloDopamine.Application.Game;

public class GameManager : IGameManager
{
    public IGame Game { get; }
    public IHero LocalPlayer { get; }
    public IEnumerable<IHero> Heroes { get; }
    public IEnumerable<IMinion> AllyMinion { get; }
    public IEnumerable<IMinion> EnemyMinions { get; }

    public IEnumerable<IMinion> AllMinions => AllyMinion.Union(EnemyMinions);

    public IEnumerable<IMissile> Missiles { get; }

    public GameManager(IGame game, IHero localPlayer, IEnumerable<IHero> heroes, IEnumerable<IMinion> allyMinion,
        IEnumerable<IMinion> enemyMinions, IEnumerable<IMissile> missiles)
    {
        Game = game;
        LocalPlayer = localPlayer;
        Heroes = heroes;
        AllyMinion = allyMinion;
        EnemyMinions = enemyMinions;
        Missiles = missiles;
    }
}