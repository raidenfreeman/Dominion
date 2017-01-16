using Dominion.CardData.Interfaces;

namespace Dominion.CardData.Cards.Kingdom.Actions
{
    public class Spy : IAction, IKingdomCard
    {
        public string Description { get; private set; } = "+1 ICard, +1 Action, Each player (including you) reveals the top card of his deck and either discards it or puts it back, your chouce.";
        public CommonCardData CommonCardData { get; private set; } = new CommonCardData(15, 4, "Spy");
    }
}
