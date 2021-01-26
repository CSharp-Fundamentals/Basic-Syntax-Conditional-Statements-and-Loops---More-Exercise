using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());

            double currentBalance = balance;
            double moneySpend = 0;

            while (true)
            {
                string game = Console.ReadLine();

                if (game == "Game Time")
                {
                    break;
                }
                double price = 0;
                switch (game)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }
                if (currentBalance < price)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }

                moneySpend += price;
                currentBalance -= price;
                Console.WriteLine($"Bought {game}");

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

            }
            Console.WriteLine($"Total spent: ${moneySpend:F2}. Remaining: ${balance - moneySpend:F2}");

        }
    }
}
