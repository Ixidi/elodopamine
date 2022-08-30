using EloDopamine.Api.Game;
using EloDopamine.Api.Math;

namespace EloDopamine.Application.Game;

public class Hero : GameObject, IHero
{
    public ISpellBook SpellBook { get; }
    public float MovementSpeed { get; }
    public bool IsMoving { get; }
    public bool IsDashing { get; }
    public IEnumerable<IVector3> NavigationArray { get; }

    public Hero(string name, IVector3 position, Team team, float health, bool isVisible, float attackRange,
        ISpellBook spellBook, IEnumerable<IVector3> navigationArray, float movementSpeed, bool isMoving,
        bool isDashing) : base(name,
        position, team, health, isVisible, attackRange)
    {
        SpellBook = spellBook;
        NavigationArray = navigationArray;
        MovementSpeed = movementSpeed;
        IsMoving = isMoving;
        IsDashing = isDashing;
    }
}