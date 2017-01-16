using Dominion.CardData.Interfaces;
using System.Collections.Generic;

namespace Dominion.Data
{
    public class BoardData
    {
        public BoardData(List<PlayerData> players, List<IKingdomCard> selectedKingdomCards)
        {
            Players = players;
            StockpileData = new StockpileData(players.Count, selectedKingdomCards);
        }

        public List<PlayerData> Players { get; private set; }

        public StockpileData StockpileData { get; private set; }

    }
}
