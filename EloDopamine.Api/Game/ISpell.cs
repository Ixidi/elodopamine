namespace EloDopamine.Api.Game;

public interface ISpell
{
    string Name { get; }
    float ReadyAt { get; }
    int Level { get; }
}