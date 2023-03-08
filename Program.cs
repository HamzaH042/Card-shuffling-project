using System;

namespace CardShufflingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] deck = new string[52];
            int index = 0;

            // create deck of cards
            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    deck[index] = value + " of " + suit;
                    index++;
                }
            }

            // shuffle deck
            Random rand = new Random();
            for (int i = 0; i < deck.Length - 1; i++)
            {
                int j = rand.Next(i, deck.Length);
                string temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }

            // deal cards
            Console.Write("Enter the number of players: ");
            int numPlayers = int.Parse(Console.ReadLine());
            int numCards = deck.Length / numPlayers;

            for (int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine("Player " + (i + 1) + ":");
                for (int j = 0; j < numCards; j++)
                {
                    Console.WriteLine(deck[(j * numPlayers) + i]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

