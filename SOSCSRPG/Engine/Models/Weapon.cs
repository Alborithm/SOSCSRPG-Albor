using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; } 

        public Weapon(int ItemTypeID, string Name, int Price, int MinimumDamage, int MaximumDamage) 
            : base(ItemTypeID, Name, Price)
        {
            this.MinimumDamage = MinimumDamage;
            this.MaximumDamage = MaximumDamage;
        }

        public new Weapon Clone()
        {
            return new Weapon(this.ItemTypeID, this.Name, this.Price, this.MinimumDamage, this.MaximumDamage);
        }
    }
}
