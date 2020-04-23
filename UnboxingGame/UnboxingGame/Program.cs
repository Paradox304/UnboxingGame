using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame
{
    class Program
    {
        public static void Main()
        {
            var itemCommon1 = new Item() { itemName = "Tec-9 I Army Mesh", itemPrice = 50, itemRarity = "Common" };
            var itemCommon2 = new Item() { itemName = "Dual Berettas I Colony", itemPrice = 100, itemRarity = "Common" };
            var itemCommon3 = new Item() { itemName = "Galil AR I Black Sand", itemPrice = 150, itemRarity = "Common" };
            var itemCommon4 = new Item() { itemName = "MP7 I Urban Hazard", itemPrice = 200, itemRarity = "Common" };
            var itemCommon5 = new Item() { itemName = "Sawed-Off I Jungle Thicket", itemPrice = 250, itemRarity = "Common" };
            var itemCommon6 = new Item() { itemName = "MAC-10 I Whitefish", itemPrice = 350, itemRarity = "Common" };
            var itemCommon7 = new Item() { itemName = "MAG-7 I Hard Water", itemPrice = 400, itemRarity = "Common" };
            var itemCommon8 = new Item() { itemName = "SCAR-20 I Storm", itemPrice = 450, itemRarity = "Common" };
            var itemCommon9 = new Item() { itemName = "SSG 08 I Blue Spruce", itemPrice = 500, itemRarity = "Common" };
            var itemCommon10 = new Item() { itemName = "PP-Bizon I Harvester", itemPrice = 300, itemRarity = "Common" };

            var itemRare1 = new Item() { itemName = "StatTrak™ Sawed-Off | Zander", itemPrice = 550, itemRarity = "Rare" };
            var itemRare2 = new Item() { itemName = "StatTrak™ XM1014 | Oxide Blaze", itemPrice = 600, itemRarity = "Rare" };
            var itemRare3 = new Item() { itemName = "StatTrak™ R8 Revolver | Survivalist", itemPrice = 650, itemRarity = "Rare" };
            var itemRare4 = new Item() { itemName = "StatTrak™ UMP-45 | Corporal", itemPrice = 700, itemRarity = "Rare" };
            var itemRare5 = new Item() { itemName = "StatTrak™ P2000 | Oceanic", itemPrice = 750, itemRarity = "Rare" };
            var itemRare6 = new Item() { itemName = "StatTrak™ R8 Revolver | Grip", itemPrice = 800, itemRarity = "Rare" };
            var itemRare7 = new Item() { itemName = "StatTrak™ G3SG1 | Hunter", itemPrice = 850, itemRarity = "Rare" };
            var itemRare8 = new Item() { itemName = "StatTrak™ FAMAS | Crypsis", itemPrice = 900, itemRarity = "Rare" };
            var itemRare9 = new Item() { itemName = "StatTrak™ AWP | Worm God", itemPrice = 950, itemRarity = "Rare" };
            var itemRare10 = new Item() { itemName = "StatTrak™ XM1014 | Oxide Blaze", itemPrice = 1000, itemRarity = "Rare" };

            var itemEpic1 = new Item() { itemName = "Souvenir Sawed-Off | Rust Coat", itemPrice = 1200, itemRarity = "Epic" };
            var itemEpic2 = new Item() { itemName = "Souvenir Desert Eagle | Urban DDPAT", itemPrice = 1400, itemRarity = "Epic" };
            var itemEpic3 = new Item() { itemName = "Souvenir Nova | Mandrel", itemPrice = 1600, itemRarity = "Epic" };
            var itemEpic4 = new Item() { itemName = "Souvenir USP-S | Royal Blue", itemPrice = 1800, itemRarity = "Epic" };
            var itemEpic5 = new Item() { itemName = "Souvenir UMP-45 | Urban DDPAT", itemPrice = 2000, itemRarity = "Epic" };
            var itemEpic6 = new Item() { itemName = "Souvenir MP7 | Gunsmoke", itemPrice = 2200, itemRarity = "Epic" };
            var itemEpic7 = new Item() { itemName = "Souvenir P250 | Gunsmoke", itemPrice = 2400, itemRarity = "Epic" };
            var itemEpic8 = new Item() { itemName = "Souvenir SSG 08 | Acid Fade", itemPrice = 2600, itemRarity = "Epic" };
            var itemEpic9 = new Item() { itemName = "Souvenir PP-Bizon | Chemical Gree", itemPrice = 2800, itemRarity = "Epic" };
            var itemEpic10 = new Item() { itemName = "Souvenir Glock-18 | Night", itemPrice = 3000, itemRarity = "Epic" };

            var itemMythical1 = new Item() { itemName = "StatTrak™ Stiletto Knife | Stained", itemPrice = 3300, itemRarity = "Mythical" };
            var itemMythical2 = new Item() { itemName = "StatTrak™ Flip Knife | Forest DDPAT", itemPrice = 3600, itemRarity = "Mythical" };
            var itemMythical3 = new Item() { itemName = "StatTrak™ Falchion Knife | Safari Mesh", itemPrice = 3900, itemRarity = "Mythical" };
            var itemMythical4 = new Item() { itemName = "StatTrak™ Huntsman Knife | Stained", itemPrice = 4200, itemRarity = "Mythical" };
            var itemMythical5 = new Item() { itemName = "StatTrak™ Flip Knife | Ultraviolet", itemPrice = 4500, itemRarity = "Mythical" };
            var itemMythical6 = new Item() { itemName = "StatTrak™ Huntsman Knife | Tiger Tooth", itemPrice = 4800, itemRarity = "Mythical" };
            var itemMythical7 = new Item() { itemName = "StatTrak™ Gut Knife | Doppler", itemPrice = 5200, itemRarity = "Mythical" };
            var itemMythical8 = new Item() { itemName = "StatTrak™ Bowie Knife | Night", itemPrice = 5500, itemRarity = "Mythical" };
            var itemMythical9 = new Item() { itemName = "StatTrak™ Gut Knife | Safari Mesh", itemPrice = 5800, itemRarity = "Mythical" };
            var itemMythical10 = new Item() { itemName = "AWP I Dragon Lore", itemPrice = 6000, itemRarity = "Mythical" };

            Storage.itemCommon.Add(itemCommon1);
            Storage.itemCommon.Add(itemCommon2);
            Storage.itemCommon.Add(itemCommon3);
            Storage.itemCommon.Add(itemCommon4);
            Storage.itemCommon.Add(itemCommon5);
            Storage.itemCommon.Add(itemCommon6);
            Storage.itemCommon.Add(itemCommon7);
            Storage.itemCommon.Add(itemCommon8);
            Storage.itemCommon.Add(itemCommon9);
            Storage.itemCommon.Add(itemCommon10);

            Storage.itemRare.Add(itemRare1);
            Storage.itemRare.Add(itemRare2);
            Storage.itemRare.Add(itemRare3);
            Storage.itemRare.Add(itemRare4);
            Storage.itemRare.Add(itemRare5);
            Storage.itemRare.Add(itemRare6);
            Storage.itemRare.Add(itemRare7);
            Storage.itemRare.Add(itemRare8);
            Storage.itemRare.Add(itemRare9);
            Storage.itemRare.Add(itemRare10);

            Storage.itemEpic.Add(itemEpic1);
            Storage.itemEpic.Add(itemEpic2);
            Storage.itemEpic.Add(itemEpic3);
            Storage.itemEpic.Add(itemEpic4);
            Storage.itemEpic.Add(itemEpic5);
            Storage.itemEpic.Add(itemEpic6);
            Storage.itemEpic.Add(itemEpic7);
            Storage.itemEpic.Add(itemEpic8);
            Storage.itemEpic.Add(itemEpic9);
            Storage.itemEpic.Add(itemEpic10);

            Storage.itemMythical.Add(itemMythical1);
            Storage.itemMythical.Add(itemMythical2);
            Storage.itemMythical.Add(itemMythical3);
            Storage.itemMythical.Add(itemMythical4);
            Storage.itemMythical.Add(itemMythical5);
            Storage.itemMythical.Add(itemMythical6);
            Storage.itemMythical.Add(itemMythical7);
            Storage.itemMythical.Add(itemMythical8);
            Storage.itemMythical.Add(itemMythical9);
            Storage.itemMythical.Add(itemMythical10);

            Game game = new Game();
            game.ChooseName();
        }
    }
}
