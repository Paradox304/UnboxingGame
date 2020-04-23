using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame
{
    public class Game
    {
        public void ChooseName()
        {
            Console.Write("Before starting the game please type in your player name: ");
            var userInput = Console.ReadLine();
            var player = new Player();
            player.CreatePlayer(userInput);
            if (player.playerName.ToLower() == "maaz")
            {
                player.playerBalance = 500000;
            }
            Console.Clear();
            StartGame(player);
        }
        public void StartGame(Player player)
        {
            Crates crate = new Crates();
            Work work = new Work();
            Market market = new Market();
            Console.WriteLine($"Welcome {player.playerName}, please choose what you want to do:");
            Console.WriteLine($"Balance: {player.playerBalance}");
            Console.WriteLine("1. Work.");
            Console.WriteLine("2. See your inventory.");
            Console.WriteLine("3. Unbox crates.");
            Console.WriteLine("4. Sell something from your inventory.");
            Console.WriteLine("5. Exit the game.");
            while (true)
            {
                Console.Write("Choose your option: ");
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    work.ChooseWork(player);
                    break;
                }
                if (userInput == "2")
                {
                    InventoryList(player);
                    break;
                }
                if (userInput == "3")
                {
                    crate.ChooseCrate(player);
                    break;
                }
                if (userInput == "4")
                {
                    market.chooseItem(player);
                    break;
                }
                if (userInput == "5")
                {
                    Environment.Exit(0);
                }
            }
        }

        public void InventoryList(Player player)
        {
            string inventoryList = player.ListInventory();
            Console.WriteLine(inventoryList);
            StartGame(player);
        }
    }
}
