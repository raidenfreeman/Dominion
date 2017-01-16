using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Festival : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "+2 Actions, +1 Buy, +2 Coins.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(19, 5, "Festival");
    }
}
