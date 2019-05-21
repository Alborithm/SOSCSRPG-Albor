using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ItemQuantity> ItemsToComplete { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }
        public List<ItemQuantity> RewardItems { get; set; }

        public Quest(int ID, string Name, string Description, List<ItemQuantity> ItemsToComplete, 
            int RewardExperience, int RewardGold, List<ItemQuantity> RewardItems)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.ItemsToComplete = ItemsToComplete;
            this.RewardExperience = RewardExperience;
            this.RewardGold = RewardGold;
            this.RewardItems = RewardItems;
        }
    }
}
