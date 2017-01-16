using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Market : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "+1 ICard, +1 Action, +1 Buy, +1 Coin.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(22, 5, "Market");
    }
}
