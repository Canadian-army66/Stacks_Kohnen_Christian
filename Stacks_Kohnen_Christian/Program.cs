using System;
using System.Collections.Generic;

namespace Stacks_Kohnen_Christian
{
    class Program
    {
        static void Main(string[] args)
        {
            Card[] myCardsArray = new Card[]  //creates an array that uses the card class and getters to put in the appropriate values
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

            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);  //creates a new deck and pushes the cards in the array to that deck

            Console.WriteLine("Cards in Deck:");  //writes a header for the card list
            foreach (Card card in startingDeck)  //for each card in the deck, it prints the number and the suit
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}");
            }

            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");  //counts and prints the number of cards in the deck

            List<Card> myHand = new List<Card>();  //creates a new list called MyHand
            myHand.Add(new Card("Jack", "Daimonds"));
            myHand.Add(new Card("2", "Clubs"));
            myHand.Add(new Card("9", "Daimonds"));

            Console.WriteLine("Got any 8's?");  //go fish
            if (startingDeck.Count > 0)  //if the card count is greater than 0, pop a card from my hand
            {
                myHand.Add(startingDeck.Pop());
            }

            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");  //rewrites the card count

            startingDeck.Push(myHand[0]);  //put one card in my hand
            myHand.RemoveAt(0);  //delete one card from the deck

            Console.WriteLine("Cards in Deck:");  //writes a header for the card list
            foreach (Card card in startingDeck)  //for each card in the deck, it prints the number and the suit
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}");
            }
        }
    }
}