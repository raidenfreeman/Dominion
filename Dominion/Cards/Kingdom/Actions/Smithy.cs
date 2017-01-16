using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Smithy : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "+3 Cards.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(14, 4, "Smithy");
    }
}
