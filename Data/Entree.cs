/* Author: Roy Fernandez
 * Class: Entree.cs
 * Purpose: A class representing all the entrees
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public abstract class Entree
    {
        /// <summary>
        /// Returns price of item
        /// </summary>
        /// <return>A double stating the price</return>
        double Price { get; }

        /// <summary>
        /// Returns calories of item
        /// </summary>
        /// <return>A uint stating the calories</return>
        uint Calories { get; }

        /// <summary>
        /// Returns a List of the special instructions for the order
        /// </summary>
        /// <return>A List of strings for order</return>
        List<string> SpecialInstructions { get; }
    }
}
