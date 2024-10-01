using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Kohnen_Christian
{
    internal class Card
    {
        public string Number { get; }  //creates an automatic number getter
        public string Suit { get; }  //creates an automatic suit getter
        public Card(string numParam, string suitParam)  //creates a constructor that assigns the number getter and suit getter
        {
            Number = numParam;
            Suit = suitParam;
        }
    }
}
