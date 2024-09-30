using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Kohnen_Christian
{
    internal class Card
    {
        public char Number { get; }
        public string Suit { get; }
        public Card(char numParam, string suitParam)
        {
            Number = numParam;
            Suit = suitParam;
        }
    }
}
