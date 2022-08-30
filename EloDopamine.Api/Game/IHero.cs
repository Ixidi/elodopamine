using EloDopamine.Api.Math;

namespace EloDopamine.Api.Game;

public interface IHero : IGameObject
{
    ISpellBook SpellBook { get; }

    //TODO buffs
    float MovementSpeed { get; }
    bool IsMoving { get; }
    bool IsDashing { get; }
    IEnumerable<IVector3> NavigationArray { get; }
}