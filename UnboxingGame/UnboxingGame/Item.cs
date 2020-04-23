using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame
{
    public class Item
    {
        public string itemName { get; set; }
        public string itemRarity { get; set; }

        /* 
         * Rarities:
         * Common = 50%
         * Rare = 30%
         * Epic = 15%
         * Mythical = 5%
         */
        public decimal itemPrice { get; set; }
        /*
         * Price Range:
         * Common = $50-$500
         * Rare = $500-$1000
         * Epic = $1000-$3000
         * Mythical = $3000-$6000
         */

         public void CreateItem (string itemName, string itemRarity, decimal itemPrice)
         {
            this.itemName = itemName;
            this.itemRarity = itemRarity;
            this.itemPrice = itemPrice;
         }
        
    }
}
