using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom
{
    public class Gardens : IVictoryCard, IKingdomCard
    {
        public int VictoryValue { get; private set; }

        public string Description { get; private set; } =
            "Worth 1 Victory for every 10 cards in your deck (rounded down).";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(10, 4, "Gardens");
    }
}
