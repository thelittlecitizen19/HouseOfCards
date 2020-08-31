using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Cards
{
    public class Card
    {
        public CardType Type { get; }

        public int Number { get; }

        public Card(CardType cardType, int number)
        {
            Type = cardType;
            Number = number;
        }

        public override string ToString()
        {
            return $"# {Number} {Type}";
        }
    }
}
