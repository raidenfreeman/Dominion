using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class CouncilRoom : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "+4 Cards, +1 Buy, Each other player draws a card.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(18, 5, "Council Room");
    }
}
