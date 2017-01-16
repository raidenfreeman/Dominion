using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Witch : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "+2 Cards, Each other player gains a CurseCard card.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(24, 5, "Witch");
    }
}
