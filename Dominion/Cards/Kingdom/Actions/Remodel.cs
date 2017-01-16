using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Remodel : IAction, IKingdomCard
    {
        public string Description { get; private set; } =
            "Trash a card from your hand. Gain a card costing up to 2 Coins more than the trashed card.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(13, 4, "Remodel");
    }
}
