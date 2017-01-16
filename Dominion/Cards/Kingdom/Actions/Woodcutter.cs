using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Woodcutter : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "+1 Buy, +2 Coins.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(6, 3, "Woodcutter");
    }
}
