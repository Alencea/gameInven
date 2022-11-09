using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameInventory
{

    /// <summary>
    /// sets up weapon inherits from clue
    /// also setsup weapon damage
    /// </summary>
    internal class Weapon : Clue
    {
    private int damage;
    private DamageType damageType;
        /// <summary>
        /// sets up peramiters for weapon
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="weight"></param>
        /// <param name="value"></param>
    public Weapon(String name, String description, double weight, double value) : base(name, description, weight, value)
    {
       
    }
}
}

