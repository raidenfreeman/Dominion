using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Treasures
{
    public class Copper : ITreasureCard
    {
        public int CoinValue { get; private set; } = 1;
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(26, 0, "Copper");
    }
}
