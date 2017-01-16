using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Victory
{
    public class Province : IVictoryCard
    {
        public int VictoryValue { get; private set; } = 6;
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(31, 8, "Province");
    }
}
