using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Laboratory : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "+2 Cards, +1 Action.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(20, 5, "Laboratory");
    }
}
