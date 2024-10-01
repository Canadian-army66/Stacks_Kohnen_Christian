using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Kohnen_Christian
{
    internal class Card
    {
        public string Number { get; }
        public string Suit { get; }
        public Card(string numParam, string suitParam)
        {
            Number = numParam;
            Suit = suitParam;
        }
    }
}
