using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Moat : IAction, IKingdomCard
    {
        public string Description { get; private set; } =
            "+2 Cards, When another player plays an Attack card, you may reveal this from your hand. If you do, you are unaffected by that Attack.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(3, 2, "Moat");
    }
}
