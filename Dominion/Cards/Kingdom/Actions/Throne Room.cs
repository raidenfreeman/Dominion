using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class ThroneRoom : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "Choose an Action card in your hand. Play it twice.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(17, 4, "Throne Room");
    }
}
