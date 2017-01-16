using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Adventurer : IAction, IKingdomCard
    {
        public string Description { get; private set; } =
            "Reveal cards from your deck until you reveal 2 Treasure cards. Put those Treasure cards in your hand and discard the other revealed cards.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(25, 6, "Adventurer");
    }
}
