using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Cards
{
    public class GameCard: Card
    {
        public bool IsVisable { get; set; }

        public GameCard(CardType cardType, int number) : base(cardType, number)
        {
            IsVisable = false;
        }
        public GameCard(CardType cardType, int number, bool isVisable) : base(cardType, number)
        {
            IsVisable = isVisable;
        }

        public override string ToString()
        {
            return IsVisable ? base.ToString() : "Unvisable Card";
        }
    }
}
