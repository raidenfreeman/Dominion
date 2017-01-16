using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Feast : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "Trash this card. Gain a card costing up to 5 Coins.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(9, 4, "Feast");
    }
}
