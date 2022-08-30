using EloDopamine.Api.Game;

namespace EloDopamine.Application.Game;

public class Spell : ISpell
{
    public string Name { get; }
    public float ReadyAt { get; }
    public int Level { get; }

    public Spell(string name, float readyAt, int level)
    {
        Name = name;
        ReadyAt = readyAt;
        Level = level;
    }
}