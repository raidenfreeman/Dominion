using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Treasures
{
    public class Gold : ITreasureCard
    {
        public int CoinValue { get; private set; } = 3;
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(28, 6, "Gold");
    }
}
