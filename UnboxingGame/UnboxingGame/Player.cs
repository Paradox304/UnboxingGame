using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame
{
    public class Player
    {
        public string playerName { get; set; }
        public decimal playerBalance { get; set; }
        public Item inventorySlot1 { get; set; }
        public Item inventorySlot2 { get; set; }
        public Item inventorySlot3 { get; set; }
        public Item inventorySlot4 { get; set; }
        public Item inventorySlot5 { get; set; }

        public void CreatePlayer(string playerName)
        {
            this.playerName = playerName;
            this.playerBalance = 500.00M;
            this.inventorySlot1 = null;
            this.inventorySlot2 = null;
            this.inventorySlot3 = null;
            this.inventorySlot4 = null;
            this.inventorySlot5 = null;
        }

        public void AddInventoryItem(Item item)
        {
            if (inventorySlot1 == null)
            {
                inventorySlot1 = item;
                return;
            }
            if (inventorySlot2 == null)
            {
                inventorySlot2 = item;
                return;
            }
            if (inventorySlot3 == null)
            {
                inventorySlot3 = item;
                return;
            }
            if (inventorySlot4 == null)
            {
                inventorySlot4 = item;
                return;
            }
            if (inventorySlot5 == null)
            {
                inventorySlot5 = item;
                return;
            }
            Console.WriteLine("Your inventory is full, can't hold more items.");
        }

        public string ListInventory()
        {
            StringBuilder sb = new StringBuilder();
            if (inventorySlot1 == null)
            {
                sb.AppendLine("Slot 1: None");
            } else
            {
                sb.AppendLine($"Slot 1: {this.inventorySlot1.itemName}");
            }

            if (inventorySlot2 == null)
            {
                sb.AppendLine("Slot 2: None");
            }
            else
            {
                sb.AppendLine($"Slot 2: {this.inventorySlot2.itemName}");
            }

            if (inventorySlot3 == null)
            {
                sb.AppendLine("Slot 3: None");
            }
            else
            {
                sb.AppendLine($"Slot 3: {this.inventorySlot3.itemName}");
            }

            if (inventorySlot4 == null)
            {
                sb.AppendLine("Slot 4: None");
            }
            else
            {
                sb.AppendLine($"Slot 4: {this.inventorySlot4.itemName}");
            }

            if (inventorySlot5 == null)
            {
                sb.AppendLine("Slot 5: None");
            }
            else
            {
                sb.AppendLine($"Slot 5: {this.inventorySlot5.itemName}");
            }

            return sb.ToString();
        }
    }
}
