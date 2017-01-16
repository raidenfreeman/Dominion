using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Village : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "+1 ICard, +2 Actions.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(5, 3, "Village");
    }
}
