using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameInventory
{
/// <summary>
/// the clue object inherits from item
/// </summary>
    internal class Clue : Item
    {
        private string personIncriminated;
        private bool accuracy;
        /// <summary>
        /// sets up the paramaters for clue
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="weight"></param>
        /// <param name="value"></param>
        public Clue(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
        }

    }
}

