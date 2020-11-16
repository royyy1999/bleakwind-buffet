/* Author: Roy Fernandez
 * Class: Entree.cs
 * Purpose: A base class representing common properties for entrees
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree 
    {
        public string Name { get => ToString(); }
        /// <summary>
        /// Price of the entree
        /// </summary>
        /// <value>In US dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Returns a string of the description of the item
        /// </summary>
        /// <return>A string of the description</return>
        public abstract string Description { get; }
    }
}
