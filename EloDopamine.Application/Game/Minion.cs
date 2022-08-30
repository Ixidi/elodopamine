using EloDopamine.Api.Game;
using EloDopamine.Api.Math;

namespace EloDopamine.Application.Game;

public class Minion : GameObject, IMinion
{
    public Minion(string name, IVector3 position, Team team, float health, bool isVisible, float attackRange) : base(
        name, position, team, health, isVisible, attackRange)
    {
    }
}