using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnboxingGame
{
    public static class Storage
    {
        public static List<Player> playerData = new List<Player>();

        public static List<Item> itemCommon = new List<Item>();
        public static List<Item> itemRare = new List<Item>();
        public static List<Item> itemEpic = new List<Item>();
        public static List<Item> itemMythical = new List<Item>();
    }
}
