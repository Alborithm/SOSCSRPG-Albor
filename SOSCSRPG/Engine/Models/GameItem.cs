using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; } 

        public GameItem(int ItemTypeID, string Name, int Price)
        {
            this.ItemTypeID = ItemTypeID;
            this.Name = Name;
            this.Price = Price;
        }

        public GameItem Clone()
        {
            return new GameItem(this.ItemTypeID, this.Name, this.Price);
        }
    }
}
