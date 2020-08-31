using HouseOfCards.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Game
{
    public class GameManeger
    {
        public Game GamBoard { get; set; }
        public Menu Menu { get; set; }
        public GameManeger(List<Player> players)
        {
            GamBoard = new Game(players);
        }
    }
}
