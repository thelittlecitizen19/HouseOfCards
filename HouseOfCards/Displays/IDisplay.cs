using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Displays
{
    public interface IDisplay
    {
        public void Print(string StringToPrint);

        public string GetInput();
    }
}
