using gameInventory;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace gameInventory
{
    /// <summary>
    /// code for the backpack
    /// </summary>
    internal class Backpack
    {
        /// <summary>
        /// an array for the contents of the backpack 
        /// </summary>
           ArrayList contents = new ArrayList();
        
        /// <summary>
        /// a method to add items to contents
        /// </summary>
        /// <param name="item"></param>
        public void add(Item item)
        {
            contents.Add(item);
        }
        /// <summary>
        /// returns a list of weapons by looping through contents
        /// </summary>
        /// <returns></returns>
        public string ListWeapons()
        {
            string weapons = "";
            weapons += "\nWeapons--------------------------------------------------\n";
            foreach (Item i in contents)
            {
                if (i is Weapon)
            {
                weapons += i.toString();
                weapons += "\n---------------------------------------------------------\n";
            }
            
        }
            return weapons;
        }
        /// <summary>
        /// returns a list of clues by looping through contents
        /// </summary>
        /// <returns></returns>
    public string listClues()
    {
        string clues = "";
        clues += "\nClues----------------------------------------------------\n";
        foreach (Item i in contents)
        {
            if (i is Clue)
            {
            clues += i.toString();
            clues += "\n---------------------------------------------------------\n";
        }
                
            }
            return clues;
        }
        /// <summary>
        /// returns a list of consumables by looping through contents
        /// </summary>
        /// <returns></returns>
public string listConsumables()
{
    string consumables = "";
    consumables += "\nConsumables----------------------------------------------\n";
    foreach (Item i in contents)
        {
    if (i is Consumable)
            {
        consumables += i.toString();
        consumables += "\n---------------------------------------------------------\n";
    }
                
            }
            return consumables;
        }
}

}
