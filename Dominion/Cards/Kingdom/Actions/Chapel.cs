using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Chapel : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "Trash up to 4 cards from your hand.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(2, 2, "Chapel");
    }
}
