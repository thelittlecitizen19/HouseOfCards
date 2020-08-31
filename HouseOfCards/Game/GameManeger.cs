using HouseOfCards.Players;
using System;
using System.Collections.Generic;
using System.Text;
using HouseOfCards.Menus;

namespace HouseOfCards.Game
{
    public class GameManeger
    {
        public Game GamBoard { get; set; }
        public PlayerMenu Menu { get; set; }
        public GameManeger(List<Player> players)
        {
            GamBoard = new Game(players);
        }

        public void RunGameFlow()
        {

        }

    }
}
