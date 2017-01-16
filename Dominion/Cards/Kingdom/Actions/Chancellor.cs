using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Chancellor : IAction, IKingdomCard
    {
        public string Description { get; private set; } =
            "+2 Coins, You may immediately put your deck into your discard pile.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(4, 3, "Chancellor");
    }
}
