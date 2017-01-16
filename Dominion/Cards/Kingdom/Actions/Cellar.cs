using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Cellar : IAction, IKingdomCard
    {
        public string Description { get; private set; } =
            "+1 Action, Discard any number of cards. +1 ICard per card discarded.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(1, 2, "Cellar");

    }
}
