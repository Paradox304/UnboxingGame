using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame
{
    public class Crates
    {
        public void ChooseCrate(Player player)
        {
            Console.WriteLine("You have chosen to buy and open crates, please choose what crate you want to buy and open:");
            Console.WriteLine("1. Normal Crate ($100)");
            Console.WriteLine("2. Special Crate ($300)");
            Console.WriteLine("3. Extra Special Crate ($500)");
            Console.WriteLine("4. Extraordinary Crate ($1000)");
            Console.WriteLine("5. Godly Crate ($2000)");
            Console.WriteLine("6. View the info of all crates and their drop chances.");
            Console.WriteLine("7. Go back.");

            while (true)
            {
                Game game = new Game();
                Console.Write("Choose your option: ");
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    if (player.playerBalance < 100)
                    {
                        Console.WriteLine("You don't have sufficient balance to afford this crate, please work to get more money.");
                    } else
                    {
                        CrateNormal(player);
                        break;
                    }
                }
                if (userInput == "2")
                {
                    if (player.playerBalance < 300)
                    {
                        Console.WriteLine("You don't have sufficient balance to afford this crate, please work to get more money.");
                    }
                    else
                    {
                        CrateSpecial(player);
                        break;
                    }
                }
                if (userInput == "3")
                {
                    if (player.playerBalance < 500)
                    {
                        Console.WriteLine("You don't have sufficient balance to afford this crate, please work to get more money.");
                    }
                    else
                    {
                        CrateESpecial(player);
                        break;
                    }
                }
                if (userInput == "4")
                {
                    if (player.playerBalance < 1000)
                    {
                        Console.WriteLine("You don't have sufficient balance to afford this crate, please work to get more money.");
                    }
                    else
                    {
                        CrateEOrdinary(player);
                        break;
                    }
                }
                if (userInput == "5")
                {
                    if (player.playerBalance < 2000)
                    {
                        Console.WriteLine("You don't have sufficient balance to afford this crate, please work to get more money.");
                    }
                    else
                    {
                        CrateGodly(player);
                        break;
                    }
                }
                if (userInput == "6")
                {
                    ViewInfoCrate(player);
                    break;
                }
                if (userInput == "7")
                {
                    game.StartGame(player);
                    break;
                }
            }
        }

        public void ViewInfoCrate(Player player)
        {
            Console.WriteLine("Normal Crate: 50% Common, 30% Rare, 15% Epic, 5% Mythical");
            Console.WriteLine("Special Crate: 30% Common, 40% Rare, 20% Epic, 10% Mythical");
            Console.WriteLine("Extra Special Crate: 15% Common, 40% Rare, 25% Epic, 20% Mythical");
            Console.WriteLine("Extraordinary Crate: 30% Rare, 40% Epic, 30% Mythical");
            Console.WriteLine("Godly Crate: 10% Rare, 50% Epic, 40% Mythical");
            Console.WriteLine();
            ChooseCrate(player);
        }

        public void CrateNormal(Player player)
        {
            player.playerBalance = player.playerBalance - 100;
            Random rand = new Random();
            int chance = rand.Next(1, 100);
            int crateSelect = rand.Next(1, 10);
            if (chance >= 1 && chance < 50) {
                Item itemUnboxed = Storage.itemCommon.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            } else if (chance >= 50 && chance <= 80) 
            {
                Item itemUnboxed = Storage.itemRare.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            } else if (chance >= 80 && chance <= 95)
            {
                Item itemUnboxed = Storage.itemEpic.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            } else
            {
                Item itemUnboxed = Storage.itemMythical.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            }
            ChooseCrate(player);
        }

        public void CrateSpecial(Player player)
        {
            player.playerBalance = player.playerBalance - 300;
            Random rand = new Random();
            int chance = rand.Next(1, 100);
            int crateSelect = rand.Next(1, 10);
            if (chance >= 1 && chance < 30)
            {
                Item itemUnboxed = Storage.itemCommon.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            }
            else if (chance >= 30 && chance < 70)
            {
                Item itemUnboxed = Storage.itemRare.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            }
            else if (chance >= 70 && chance < 90)
            {
                Item itemUnboxed = Storage.itemEpic.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            }
            else
            {
                Item itemUnboxed = Storage.itemMythical.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            }
            ChooseCrate(player);
        }

        public void CrateESpecial(Player player)
        {
            player.playerBalance = player.playerBalance - 500;
            Random rand = new Random();
            int chance = rand.Next(1, 100);
            int crateSelect = rand.Next(1, 10);
            if (chance >= 1 && chance < 15)
            {
                Item itemUnboxed = Storage.itemCommon.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            }
            else if (chance >= 15 && chance < 55)
            {
                Item itemUnboxed = Storage.itemRare.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            }
            else if (chance >= 55 && chance < 80)
            {
                Item itemUnboxed = Storage.itemEpic.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            }
            else
            {
                Item itemUnboxed = Storage.itemMythical.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            }
            ChooseCrate(player);
        }
        public void CrateEOrdinary(Player player)
        {
            player.playerBalance = player.playerBalance - 1000;
            Random rand = new Random();
            int chance = rand.Next(1, 100);
            int crateSelect = rand.Next(1, 10);
            if (chance >= 1 && chance < 30)
            {
                Item itemUnboxed = Storage.itemRare.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            }
            else if (chance >= 30 && chance < 70)
            {
                Item itemUnboxed = Storage.itemEpic.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            }
            else
            {
                Item itemUnboxed = Storage.itemMythical.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            }
            ChooseCrate(player);
        }

        public void CrateGodly(Player player)
        {
            player.playerBalance = player.playerBalance - 2000;
            Random rand = new Random();
            int chance = rand.Next(1, 100);
            int crateSelect = rand.Next(1, 10);
            if (chance >= 1 && chance < 10)
            {
                Item itemUnboxed = Storage.itemRare.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            }
            else if (chance >= 10 && chance < 60)
            {
                Item itemUnboxed = Storage.itemEpic.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            }
            else
            {
                Item itemUnboxed = Storage.itemMythical.ElementAt<Item>(crateSelect);
                Console.WriteLine($"You found a {itemUnboxed.itemRarity} item which is worth ${itemUnboxed.itemPrice}");
                player.AddInventoryItem(itemUnboxed);
            }
            ChooseCrate(player);
        }
    }
}
