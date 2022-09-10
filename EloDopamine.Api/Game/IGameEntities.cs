namespace EloDopamine.Api.Game;

public interface IGameEntities
{
    IHero LocalPlayer { get; }
    IEnumerable<IHero> Heroes { get; }
    IEnumerable<IMinion> AllyMinion { get; }
    IEnumerable<IMinion> EnemyMinions { get; }
    IEnumerable<IMinion> AllMinions { get; }
    IEnumerable<IMissile> Missiles { get; }
}