using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Library : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "Draw until you have 7 cards in hand. You may set aside any Action cards drawn this way, as you draw them; discard the set aside cards after you finish drawing.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(21, 5, "Library");
    }
}
