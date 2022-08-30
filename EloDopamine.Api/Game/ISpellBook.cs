namespace EloDopamine.Api.Game;

public interface ISpellBook
{
    ISpell Q { get; }
    ISpell W { get; }
    ISpell E { get; }
    ISpell R { get; }

    ISpell FirstSummonerSpell { get; }
    ISpell SecondSummonerSpell { get; }
}