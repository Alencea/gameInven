using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameInventory
{
    /// <summary>
    /// consumable object inherats from item
    /// </summary>
    internal class Consumable : Item
    {
        private int healthEffect;
        private int dosesRemaining;
        /// <summary>
        /// sets up paramiters for consumable
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="weight"></param>
        /// <param name="value"></param>
        public Consumable(string name, string description, double weight, double value) : base(name, description, weight, value)
        {

        }
    }
}


