using System;

namespace Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string nameOfGame = Console.ReadLine();
            double totalSpent = 0.00;

            while (nameOfGame != "Game Time")
            {
                double priceOfGame = 0.00;
                switch (nameOfGame)
                {
                    case "OutFall 4":
                        priceOfGame = 39.99;
                        break;
                    case "CS: OG":
                        priceOfGame = 15.99;
                        break;
                    case "Zplinter Zell":
                        priceOfGame = 19.99;
                        break;
                    case "Honored 2":
                        priceOfGame = 59.99;
                        break;
                    case "RoverWatch":
                        priceOfGame = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        priceOfGame = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        nameOfGame = Console.ReadLine();
                        continue;
                }

                if (currentBalance < priceOfGame)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    Console.WriteLine($"Bought {nameOfGame}");
                    totalSpent += priceOfGame;
                    currentBalance -= priceOfGame;

                }

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                else
                {
                    nameOfGame = Console.ReadLine();
                }
            }
            Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${currentBalance:F2}");
        }
    }
}
