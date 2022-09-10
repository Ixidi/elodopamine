using EloDopamine.Api.Game;

namespace EloDopamine.Application.Game;

public class GameEntities : IGameEntities
{
    public IHero LocalPlayer { get; }
    public IEnumerable<IHero> Heroes { get; }
    public IEnumerable<IMinion> AllyMinion { get; }
    public IEnumerable<IMinion> EnemyMinions { get; }
    public IEnumerable<IMinion> AllMinions { get; }
    public IEnumerable<IMissile> Missiles { get; }

    public GameEntities(IHero localPlayer, IEnumerable<IHero> heroes, IEnumerable<IMinion> allyMinion, IEnumerable<IMinion> enemyMinions, IEnumerable<IMinion> allMinions, IEnumerable<IMissile> missiles)
    {
        LocalPlayer = localPlayer;
        Heroes = heroes;
        AllyMinion = allyMinion;
        EnemyMinions = enemyMinions;
        AllMinions = allMinions;
        Missiles = missiles;
    }
}