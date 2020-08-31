using HouseOfCards.Cards;
using System;
using System.Collections.Generic;

namespace HouseOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            CardPack cardPack = new CardPack(new Dictionary<int, int>() { { 1, 2 }, { 2, 1 } });
            while (cardPack.GetRemainingCardsNumber() != 0)
            {
                Card card = cardPack.GetCard();
                Console.WriteLine($"# {card.Number} {card.Type}");
            }
            
        }
    }
}
