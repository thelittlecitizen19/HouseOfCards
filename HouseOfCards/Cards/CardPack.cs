using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseOfCards.Cards
{
    public class CardPack
    {
        private Stack<Card> _cardsStack;

        public CardPack(Dictionary<int, int> cardsCountDict)
        {
            _cardsStack = new Stack<Card>();
            foreach (CardType type in (CardType[])Enum.GetValues(typeof(CardType)))
            {
                foreach (KeyValuePair<int, int> kvp in cardsCountDict)
                {
                    for (int i = 0; i < kvp.Value; i++)
                        _cardsStack.Push(new Card(type, kvp.Key));
                }
            }
            SufflePack();
        }

        public void SufflePack()
        {
            Random rnd = new Random();
            var cards = _cardsStack.ToArray();
            _cardsStack.Clear();
            foreach (var card in cards.OrderBy(c => rnd.Next()))
                _cardsStack.Push(card);
        }

        public Card GetCard()
        {
            return _cardsStack.Pop();
        }

        public int GetRemainingCardsNumber()
        {
            return _cardsStack.Count();
        }
    }
}
