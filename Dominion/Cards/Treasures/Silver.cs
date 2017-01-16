using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Treasures
{
    public class Silver : ITreasureCard
    {
        public int CoinValue { get; private set; } = 2;
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(27, 3, "Silver");
    }
}
