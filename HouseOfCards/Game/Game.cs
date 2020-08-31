using HouseOfCards.Cards;
using HouseOfCards.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Game
{
    public class Game
    {
        public List<Player> Players { get; set; }
        public CardPack Pack { get; set; }
        public Dictionary<CardType, Stack<Card>> MiddleCards { get; set; }
        public int RemainMistakes { get; set; }
        public int RemainHints { get; set; }
        public Game(List<Player> players)
        {
            Pack = new CardPack(GetCardCount());
            Players = players;
            RemainHints = 5;
            RemainMistakes = 4;


        }
        private Dictionary<int, int> GetCardCount()
        {
            Dictionary<int, int> cardCount = new Dictionary<int, int>();
            cardCount.Add(1, 3);
            cardCount.Add(2, 2);
            cardCount.Add(3, 2);
            cardCount.Add(4, 2);
            cardCount.Add(5, 1);
            return cardCount;

        }
        private void InitMiddleCards()
        {
            MiddleCards = new Dictionary<CardType, Stack<Card>>();
            foreach (CardType type in (CardType[])Enum.GetValues(typeof(CardType)))
            {
                MiddleCards[type] = new Stack<Card>();
            }
        }
        public bool AcceptPlay(Card card)
        {
            
        }
        private bool IsPlayLegal(Card card)
        {

        }
    }
}
