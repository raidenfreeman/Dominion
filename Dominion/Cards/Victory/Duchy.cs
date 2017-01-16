using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Victory
{
    public class Duchy : IVictoryCard
    {
        public int VictoryValue { get; private set; } = 3;
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(30, 5, "Duchy");
    }
}
