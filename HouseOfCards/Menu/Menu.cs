using HouseOfCards.Displays;
using HouseOfCards.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Menu
{
    public class Menu
    {
        private IDisplay _displayer;
        public Dictionary<string, Action> Operations { get; set; }
        public Menu(IDisplay displayer)
        {
            Operations = new Dictionary<string, Action>();
            _displayer = displayer;
            
        }
        public void LoadOperations(Player player)
        {
            Operations.Clear();
            Operations.Add("1", player.PlayCard);
            Operations.Add("2", player.GetHint);
            Operations.Add("3", player.ThrowCard);
        }
        public void DisplayMenu()
        {
            _displayer.Print("for play card press 1");
            _displayer.Print("for get hint press 2");
            _displayer.Print("for throw card press 3");
        }

    }
}
