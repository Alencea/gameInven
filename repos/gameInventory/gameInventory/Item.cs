using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameInventory
{
    /// <summary>
    /// sets up item object
    /// </summary>
    internal class Item
    {
        protected string name;
        protected string description;
        protected double weight;
        protected double value;
        /// <summary>
        /// give paramiters to item
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="weight"></param>
        /// <param name="value"></param>
        public Item(string name, string description, double weight, double value)
        {
            this.name = name;
            this.description = description;
            this.weight = weight;
            this.value = value;
        }
        /// <summary>
        /// returns all values as strings
        /// </summary>
        /// <returns></returns>
        public string toString()
        {
            return "Item name: " + name + "\nDescription: " + description + "\nWeight: " + weight + " pounds" + "\nValue: "
                    + value + " gold pieces";
        }
        /// <summary>
        /// safty line for none implimented exceptions
        /// </summary>
        /// <param name="v"></param>
        public static implicit operator Item(ArrayList v)
        {
            throw new NotImplementedException();
        }
    }
}
