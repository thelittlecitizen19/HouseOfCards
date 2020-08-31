using HouseOfCards.Cards;
using HouseOfCards.Displays;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Players
{
    public class Player
    {
        private IDisplay _display;
        public Dictionary<int, GameCard> CardsInHand { get; set; }

        public event Func<GameCard, GameCard> OnPlayCard;

        public event Action OnGetHint;

        public event Action OnThrowCard;

        public Player(IDisplay display)
        {
            _display = display;
            CardsInHand = new Dictionary<int, GameCard>();
            OnPlayCard = null;
            OnGetHint = null;
            OnThrowCard = null;
        }

        public void PlayCard()
        {
            int cardIndex = ChooseCardFromHand();
            CardsInHand[cardIndex] = OnPlayCard?.Invoke(CardsInHand[cardIndex]);
        }

        public void GetHint()
        {
            OnGetHint?.Invoke();
        }

        public void ThrowCard()
        {
            OnThrowCard?.Invoke();

        }

        private int ChooseCardFromHand()
        {
            foreach (KeyValuePair<int,GameCard> kvp in CardsInHand)
            {
                _display.Print($"{kvp.Key} - {kvp.Value}");
            }
            int intInput;
            _display.Print("chose card: ");
            string stringInput = _display.GetInput();
            while (!Int32.TryParse(stringInput, out intInput) || !CardsInHand.ContainsKey(intInput))
            {
                _display.Print("Wrong input, chose card: ");
                stringInput = _display.GetInput();
            }
            return intInput;
        }
    }
}
