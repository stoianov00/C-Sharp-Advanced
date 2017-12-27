using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cardsPowers = GetCardPowers();
            Dictionary<string, int> cardTypes = GetCardType();

            Dictionary<string, HashSet<int>> cards = new Dictionary<string, HashSet<int>>();

            string input = Console.ReadLine();

            while (input != "JOKER")
            {
                string[] tokens = input.Split(':');
                string name = tokens[0];
                string[] playerCards = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playerCards)
                {
                    string cardPower = card.Substring(0, card.Length - 1);
                    string cardType = card.Substring(card.Length - 1);

                    int sum = cardsPowers[cardPower] * cardTypes[cardType];

                    if (!cards.ContainsKey(name))
                    {
                        cards[name] = new HashSet<int>();
                    }

                    cards[name].Add(sum);
                }
                input = Console.ReadLine();
            }

            foreach (var player in cards)
            {
                string name = player.Key;
                int cardsSum = player.Value.Sum();

                Console.WriteLine($"{name}: {cardsSum}");
            }

        }

        private static Dictionary<string, int> GetCardPowers()
        {
            Dictionary<string, int> powers = new Dictionary<string, int>();
            for (int i = 2; i <= 10; i++)
            {
                powers[i.ToString()] = i;
            }
            powers["J"] = 11;
            powers["Q"] = 12;
            powers["K"] = 13;
            powers["A"] = 14;

            return powers;
        }

        private static Dictionary<string, int> GetCardType()
        {
            Dictionary<string, int> cardTypes = new Dictionary<string, int>();

            cardTypes["S"] = 4;
            cardTypes["H"] = 3;
            cardTypes["D"] = 2;
            cardTypes["C"] = 1;

            return cardTypes;
        }
    }
}

