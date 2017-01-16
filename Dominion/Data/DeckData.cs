using Dominion.CardData.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Dominion.Data
{
    public class DeckData
    {
        public DeckData(IEnumerable<ICard> deck)
        {
            this.Cards = deck.ToList();
        }

        public List<ICard> Cards { get; private set; }

    }
}