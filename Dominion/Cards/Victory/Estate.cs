using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Victory
{
    public class Estate : IVictoryCard
    {
        public int VictoryValue { get; private set; } = 1;
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(29, 2, "Estate");
    }
}
