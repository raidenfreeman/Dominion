using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Mine : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "Trash a Treasure card from your hand. Gain a Treasure card costing up to 3 Coins more; put it into your hand.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(23, 5, "Mine");
    }
}
