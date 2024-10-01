using System;
using System.Collections.Generic;

namespace Stacks_Kohnen_Christian
{
    class Program
    {
        static void Main(string[] args)
        {
            Card[] myCardsArray = new Card[]
            {
                new Card("Ace","Spades"),
                new Card("Queen","Daimonds"),
                new Card("4","Hearts"),
                new Card("King","Clubs"),
                new Card("5","Spades"),
                new Card("Ace","Hearts"),
                new Card("10","Daimonds"),
                new Card("Jack","Clubs"),
            };

            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}");
            }

            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

            List<Card> myHand = new List<Card>();
            myHand.Add(new Card("Jack", "Daimonds"));
            myHand.Add(new Card("2", "Clubs"));
            myHand.Add(new Card("9", "Daimonds"));

            Console.WriteLine("Got any 8's?");
            if (startingDeck.Count > 0)
            {
                myHand.Add(startingDeck.Pop());
            }

            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

            startingDeck.Push(myHand[0]);
            myHand.RemoveAt(0);

            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}");
            }
        }
    }
}