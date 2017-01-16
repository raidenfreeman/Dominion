using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Moneylender : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "Trash a Copper from your hand. If you do, +3 Coins.";

        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(12, 4, "Moneylender");
    }
}
