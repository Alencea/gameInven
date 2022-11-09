using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameInventory
{
    internal class GameInventoryDriver
    {
        /// <summary>
        /// start of program
        /// </summary>
        /// <param name="args"></param>
        public static void main(string[] args)
        {
            // sets up backpack
            Backpack myBackpack = new Backpack();
            //adds items to backpack
            myBackpack.add(new Clue("Letter", "A threatening letter from Fred", .1, 0));
            myBackpack.add(new Weapon("Sword", "A bright shiny sword", 10.0, 25.0));
            myBackpack.add(new Consumable("Aspirin", "A little something for your aching head", .5, 1.0));
            myBackpack.add(new Consumable("Chocolate cake", "Delicious cake", 2.0, 7.5));
            myBackpack.add(new Weapon("Battle Axe", "A wicked looking battle axe", 15.0, 35.0));
            myBackpack.add(new Clue("Shirt", "A bloody shirt", 2.0, 0));
            myBackpack.add(new Weapon("Pole Arm", "A heavy stick for hitting things", 8.0, 10.0));
            myBackpack.add(new Consumable("Bandages", "A box of assorted bandages", .6, 1.0));
            //prints the weapon, clue, and consumable lists
            Console.WriteLine(myBackpack.ListWeapons());
            Console.WriteLine(myBackpack.listClues());
            Console.WriteLine(myBackpack.listConsumables());


        }
    }

}
