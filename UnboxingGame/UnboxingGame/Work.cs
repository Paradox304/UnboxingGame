using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame
{
    public class Work
    {
        public void ChooseWork(Player player)
        {
            Game game = new Game();
            Console.WriteLine("What work do you want to do:");
            Console.WriteLine("1. Normal Work (35$, Chance of completion 80%)");
            Console.WriteLine("2. Pickpocket ($200, Chance of completion 65%, Penalty $50)");
            Console.WriteLine("3. Steal ($350, Chance of completion 50%, Penalty $80)");
            Console.WriteLine("4. Kidnap ($500, Chance of completion 30%, Penalty $100)");
            Console.WriteLine("5. Go back.");
            while (true)
            {
                Console.Write("Choose your option: ");
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    NormalWork(player);
                    break;
                }
                if (userInput == "2")
                {
                    PickPocket(player);
                    break;
                }
                if (userInput == "3")
                {
                    Steal(player);
                    break;
                }
                if (userInput == "4")
                {
                    Kidnap(player);
                    break;
                }
                if (userInput == "5")
                {
                    game.StartGame(player);
                    break;
                }
            }
        }

        public void NormalWork(Player player)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 100);
            if (randomNumber >= 1 && randomNumber <= 80)
            {
                Console.WriteLine("Successfully worked, earned $35");
                player.playerBalance = player.playerBalance + 35;
                ChooseWork(player);
                return;
            } else
            {
                Console.WriteLine("Failed to work, try again!");
                ChooseWork(player);
                return;
            }
        }

        public void PickPocket(Player player)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 100);
            if (randomNumber >= 1 && randomNumber <= 65)
            {
                Console.WriteLine("Successfully pickpocketed, earned $200");
                player.playerBalance = player.playerBalance + 200;
                ChooseWork(player);
                return;
            }
            else
            {
                Console.WriteLine("Got caught while pickpocketing, penalty $50!");
                player.playerBalance = player.playerBalance - 50;
                ChooseWork(player);
                return;
            }
        }

        public void Steal(Player player)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 100);
            if (randomNumber >= 1 && randomNumber <= 50)
            {
                Console.WriteLine("Successfully stole, earned $350");
                player.playerBalance = player.playerBalance + 350;
                ChooseWork(player);
                return;
            }
            else
            {
                Console.WriteLine("Got caught while stealing, penalty $80!");
                player.playerBalance = player.playerBalance - 80;
                ChooseWork(player);
                return;
            }
        }

        public void Kidnap(Player player)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 100);
            if (randomNumber >= 1 && randomNumber <= 30)
            {
                Console.WriteLine("Successfully kidnapped, earned $500");
                player.playerBalance = player.playerBalance + 500;
                ChooseWork(player);
                return;
            }
            else
            {
                Console.WriteLine("Got caught while kidnapping, penalty $100!");
                player.playerBalance = player.playerBalance - 100;
                ChooseWork(player);
                return;
            }
        }
    }
}
