/* Author: Roy Fernandez
 * Class name: WarriorsWater.cs
 * Purpose: Class used to represent properties of the Warriors Water.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink, IOrderItem
    {
        /// <summary>
        /// Boolean property for ice in drink.
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Boolean property for lemon in drink.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Assigns price of water
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.00;
            }
        }

        /// <summary>
        /// Gives calorie information of the water ordered.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return (uint)0.00;
            }
        }

        /// <summary>
        /// Returns a List of special instructions of water.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Converts users order to a string
        /// </summary>
        /// <returns>Users drink</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Warrior Water");
        }
    }
}
