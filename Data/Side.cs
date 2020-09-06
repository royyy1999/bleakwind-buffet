﻿/* Author: Roy Fernandez
 * Class: Side.cs
 * Purpose: A class that represents all of the sides
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    public class Side
    {
        /// <summary>
        /// Returns size of the item
        /// </summary>
        /// <returns>A size enum of item</returns>
        Size Size { get; set; }

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
