using EloDopamine.Api.Math;

namespace EloDopamine.Api.Game;

public interface IGameObject
{
    string Name { get; }
    IVector3 Position { get; }
    Team Team { get; }
    float Health { get; }
    bool IsVisible { get; }
    float AttackRange { get; }

    bool IsAlly(IGameObject obj);
    bool IsEnemy(IGameObject obj);
    float Distance(IGameObject obj);
}