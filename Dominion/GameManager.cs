using Dominion.CardData.Interfaces;
using Dominion.Data;
using System;
using System.Collections.Generic;

namespace Dominion
{
    public class GameManager
    {
        private BoardData board;

        public void InitializeGame(List<PlayerData> players, List<IKingdomCard> selectedKingdomCards)
        {
            if (players.Count > Constants.MaxPlayers || players.Count < Constants.MinPlayers)
            {
                throw new ArgumentException("Invalid number of players", nameof(selectedKingdomCards));
            }
            if (selectedKingdomCards.Count != Constants.KingdomCardsPerGame)
            {
                throw new ArgumentException("Invalid number of kingdom cards", nameof(selectedKingdomCards));
            }
            board = new BoardData(players, selectedKingdomCards);
        }
    }
}
