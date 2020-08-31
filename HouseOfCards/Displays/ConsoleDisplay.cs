using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Displays
{
    public class ConsoleDisplay : IDisplay
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void Print(string StringToPrint)
        {
            Console.WriteLine(StringToPrint);
        }
    }
}
