using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Militia : IAction, IKingdomCard
    {
        public string Description { get; private set; } =
            "+2 Coins, Each other player discards down to 3 cards in his hand.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(11, 4, "Militia");
    }
}
