using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factory
{
    public static class ItemFactory
    {
        private static List<GameItem> _statndarGameItems;

        static ItemFactory()
        {
            _statndarGameItems = new List<GameItem>();

            _statndarGameItems.Add(new Weapon(1001, "Pointy Stick", 1, 1, 2));
            _statndarGameItems.Add(new Weapon(1002, "Rusty Sword", 5, 1, 3));
            _statndarGameItems.Add(new GameItem(9001, "Snake fang", 1));
            _statndarGameItems.Add(new GameItem(9002, "Snakeskin", 2));

        }

        public static GameItem CreateGameItem(int ItemTypeID)
        {
            GameItem standarItem = _statndarGameItems.FirstOrDefault(item => item.ItemTypeID == ItemTypeID);

            if(standarItem != null)
            {
                return standarItem.Clone();
            }

            return null;
        }
    }
}
