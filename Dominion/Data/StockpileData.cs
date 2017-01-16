using Dominion.CardData.Cards.Curses;
using Dominion.CardData.Cards.Treasures;
using Dominion.CardData.Cards.Victory;
using Dominion.CardData.Interfaces;
using System.Collections.Generic;

namespace Dominion.Data
{
    public class StockpileData
    {

        public StockpileData(int numberOfPlayers, List<IKingdomCard> selectedKingdomCards)
        {
            AddKingdomCards(numberOfPlayers, selectedKingdomCards);
            AddAllVictoryCards(numberOfPlayers);
            AddCurseCards<CurseCard>(numberOfPlayers);
            AddCoppers();
            AddSilvers();
            AddGolds();
        }

        private void AddKingdomCards(int numberOfPlayers, List<IKingdomCard> kingdomCards)
        {
            StockpileDecks = new List<DeckData>();
            foreach (var selectedKingdomCard in kingdomCards)
            {
                var cardsToAdd = Constants.KingdomCardsPerGame;
                if (selectedKingdomCard is IVictoryCard)
                {
                    cardsToAdd = numberOfPlayers > 2
                        ? Constants.VictoryCardsForThreeOrFourPlayers
                        : Constants.VictoryCardsForTwoPlayers;
                }
                var deck = new List<IKingdomCard>();
                for (int i = 0; i < cardsToAdd; i++)
                {
                    deck.Add(selectedKingdomCard);
                }
                var kingdomCardsDeck = new DeckData(deck);
                StockpileDecks.Add(kingdomCardsDeck);
            }
        }

        private void AddAllVictoryCards(int numberOfPlayers)
        {
            AddVictoryCards<Estate>(numberOfPlayers);
            AddVictoryCards<Duchy>(numberOfPlayers);
            AddVictoryCards<Province>(numberOfPlayers);
        }

        private void AddVictoryCards<T>(int numberOfPlayers) where T : IVictoryCard, new()
        {
            var cardsToAdd = numberOfPlayers > 2
                        ? Constants.VictoryCardsForThreeOrFourPlayers
                        : Constants.VictoryCardsForTwoPlayers;
            var deck = new List<IVictoryCard>();
            for (int i = 0; i < cardsToAdd; i++)
            {
                deck.Add(new T());
            }
            var victoryDeck = new DeckData(deck);
            StockpileDecks.Add(victoryDeck);
        }

        private void AddCurseCards<T>(int numberOfPlayers) where T : ICurseCard, new()
        {
            var cardsToAdd = numberOfPlayers * Constants.CurseCardsPerPlayer;
            var deck = new List<ICurseCard>();
            for (int i = 0; i < cardsToAdd; i++)
            {
                deck.Add(new T());
            }
            var curseDeck = new DeckData(deck);
            StockpileDecks.Add(curseDeck);
        }

        private void AddCoppers()
        {
            var cardsToAdd = Constants.TotalCoppers;
            var deck = new List<Copper>();
            for (int i = 0; i < cardsToAdd; i++)
            {
                deck.Add(new Copper());
            }
            var curseDeck = new DeckData(deck);
            StockpileDecks.Add(curseDeck);
        }

        private void AddSilvers()
        {
            var cardsToAdd = Constants.TotalSilvers;
            var deck = new List<Silver>();
            for (int i = 0; i < cardsToAdd; i++)
            {
                deck.Add(new Silver());
            }
            var curseDeck = new DeckData(deck);
            StockpileDecks.Add(curseDeck);
        }

        private void AddGolds()
        {
            var cardsToAdd = Constants.TotalGolds;
            var deck = new List<Gold>();
            for (int i = 0; i < cardsToAdd; i++)
            {
                deck.Add(new Gold());
            }
            var curseDeck = new DeckData(deck);
            StockpileDecks.Add(curseDeck);
        }

        public List<DeckData> StockpileDecks { get; private set; }
    }
}