using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Thief : IAction, IKingdomCard
    {
        public string Description { get; private set; } =
            "Each other player reveals the top 2 cards of his deck. If they revealed any Treasure cards, they trash one of them that you choose. You may gain any or all of these trashed cards. They discard the other revealed cards.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(16, 4, "Thief");
    }
}
