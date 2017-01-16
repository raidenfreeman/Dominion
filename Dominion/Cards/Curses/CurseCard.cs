using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Curses
{
    public class CurseCard : ICurseCard
    {
        public int VictoryPoints { get; private set; } = -1;
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(32, 0, "CurseCard");

    }
}
