using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Bureaucrat : IAction, IKingdomCard
    {
        public string Description { get; private set; } =
            "Gain a silver card; put it on top of your deck. Each other player reveals a Victory card from his hand and puts it on his deck (or reveals a hand with no Victory cards).";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(8, 4, "Bureaucrat");

    }
}
