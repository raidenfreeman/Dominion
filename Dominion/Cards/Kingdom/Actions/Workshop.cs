using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Workshop : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "Gain a card costing up to 4 Coins.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(7, 3, "Workshop");
    }
}
