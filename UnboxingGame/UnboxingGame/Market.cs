using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame
{
    public class Market
    {
        public void chooseItem(Player player)
        {
            Game game = new Game();
            Console.WriteLine("You have chosen to sell an item from your inventory, please choose what item you want to sell:");
            string inventoryList = player.ListInventory();
            Console.WriteLine(inventoryList);

            while (true)
            {
                Console.Write("Please write the number of the slot of the item you want to sell (Write EXIT to exit out of this): ");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    if (player.inventorySlot1 == null)
                    {
                        Console.WriteLine("No item found in the slot you chose!");
                    } else
                    {
                        sellItem(player, player.inventorySlot1, "1");
                        break;
                    }
                } else if (userInput == "2")
                {
                    if (player.inventorySlot2 == null)
                    {
                        Console.WriteLine("No item found in the slot you chose!");
                    } else
                    {
                        sellItem(player, player.inventorySlot2, "2");
                        break;
                    }
                } else if (userInput == "3")
                {
                    if (player.inventorySlot3 == null)
                    {
                        Console.WriteLine("No item found in the slot you chose!");
                    } else
                    {
                        sellItem(player, player.inventorySlot3, "3");
                        break;
                    }
                } else if (userInput == "4")
                {
                    if (player.inventorySlot4 == null)
                    {
                        Console.WriteLine("No item found in the slot you chose!");
                    } else
                    {
                        sellItem(player, player.inventorySlot4, "4");
                        break;
                    }
                } else if (userInput == "5")
                {
                    if (player.inventorySlot5 == null)
                    {
                        Console.WriteLine("No item found in the slot you chose!");
                    } else
                    {
                        sellItem(player, player.inventorySlot5, "5");
                        break;
                    }
                } else if (userInput.ToLower() == "exit")
                {
                    game.StartGame(player);
                    break;
                }
            }
        }

        public void sellItem(Player player, Item item, string slot) {
            Game game = new Game();
            Console.WriteLine($"You have chosen to sell '{item.itemName}' which has a market value of ${item.itemPrice} and is of a rarity of '{item.itemRarity}'");
            while (true)
            {
                Console.Write("Please choose what price you want to sell it to the market for (Write EXIT to go back): ");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "exit")
                {

                }
                if (!decimal.TryParse(userInput, out decimal result))
                {
                    Console.WriteLine("Price should be a number!");
                    sellItem(player, item, slot);
                    break;
                }

                if (result <= 0)
                {
                    Console.WriteLine("Price should be more than 0!");
                    sellItem(player, item, slot);
                    break;
                }
                decimal chance = 0;
                if (result > item.itemPrice)
                {
                    chance = item.itemPrice/result * 100;
                } else if (result == item.itemPrice)
                {
                    chance = 100;
                } else if (result < item.itemPrice)
                {
                    chance = 100;
                }
                Console.WriteLine($"You are going to sell this item for ${result} with a chance of {chance}% of selling");
                Console.Write("Do you want to sell this item for this price and this chance? (Yes/No): ");
                string userInput2 = Console.ReadLine();
                if (userInput2.ToLower() == "yes")
                {
                    Random random = new Random();
                    decimal sellChance = random.Next(1, 100);
                    if (sellChance > 1 && sellChance < chance)
                    {
                        Console.WriteLine($"Successfully sold your item for ${result}");
                        player.playerBalance = player.playerBalance + result;
                        switch (slot)
                        {
                            case "1":
                                player.inventorySlot1 = null;
                                break;
                            case "2":
                                player.inventorySlot2 = null;
                                break;
                            case "3":
                                player.inventorySlot3 = null;
                                break;
                            case "4":
                                player.inventorySlot4 = null;
                                break;
                            case "5":
                                player.inventorySlot5 = null;
                                break;
                        }
                        game.StartGame(player);
                        break;
                    } else
                    {
                        Console.WriteLine("Failed to sell the item, item removed from inventory.");
                        switch (slot)
                        {
                            case "1":
                                player.inventorySlot1 = null;
                                break;
                            case "2":
                                player.inventorySlot2 = null;
                                break;
                            case "3":
                                player.inventorySlot3 = null;
                                break;
                            case "4":
                                player.inventorySlot4 = null;
                                break;
                            case "5":
                                player.inventorySlot5 = null;
                                break;
                        }
                        game.StartGame(player);
                        break;
                    }
                } else if (userInput2.ToLower() == "no") 
                {
                    sellItem(player, item, slot);
                    break;
                }
            }
        }
    }
}
