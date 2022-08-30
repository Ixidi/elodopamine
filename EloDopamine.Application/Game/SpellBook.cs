using EloDopamine.Api.Game;

namespace EloDopamine.Application.Game;

public class SpellBook : ISpellBook
{
    public ISpell Q { get; }
    public ISpell W { get; }
    public ISpell E { get; }
    public ISpell R { get; }
    public ISpell FirstSummonerSpell { get; }
    public ISpell SecondSummonerSpell { get; }

    public SpellBook(ISpell q, ISpell w, ISpell e, ISpell r, ISpell firstSummonerSpell, ISpell secondSummonerSpell)
    {
        Q = q;
        W = w;
        E = e;
        R = r;
        FirstSummonerSpell = firstSummonerSpell;
        SecondSummonerSpell = secondSummonerSpell;
    }
}