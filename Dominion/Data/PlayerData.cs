using Dominion.CardData.Interfaces;
using System.Collections.Generic;

namespace Dominion.Data
{
    public class PlayerData
    {
        public string Name { get; private set; }
        public int ID { get; private set; }

        public DeckData DeckData { get; private set; }
        public DeckData DiscardPile { get; private set; }
        public List<ICard> Hand { get; private set; }
    }
}