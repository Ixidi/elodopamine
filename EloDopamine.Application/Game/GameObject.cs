using EloDopamine.Api.Game;
using EloDopamine.Api.Math;

namespace EloDopamine.Application.Game;

public class GameObject : IGameObject
{
    public string Name { get; }
    public IVector3 Position { get; }
    public Team Team { get; }
    public float Health { get; }
    public bool IsVisible { get; }
    public float AttackRange { get; }

    public GameObject(string name, IVector3 position, Team team, float health, bool isVisible, float attackRange)
    {
        Name = name;
        Position = position;
        Team = team;
        Health = health;
        IsVisible = isVisible;
        AttackRange = attackRange;
    }

    public bool IsAlly(IGameObject obj)
    {
        return Team == obj.Team;
    }

    public bool IsEnemy(IGameObject obj)
    {
        return Team != obj.Team;
    }

    public float Distance(IGameObject obj)
    {
        var dX = obj.Position.X - Position.X;
        var dY = obj.Position.Y - Position.Y;
        var dZ = obj.Position.Z - Position.Z;
        return Convert.ToSingle(Math.Sqrt((dX * dX) + (dY * dY) + (dZ * dZ)));
    }
}