/* Author: Roy Fernandez
 * Class: IOrderItem.cs
 * Purpose: An interface for the order items
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem
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
