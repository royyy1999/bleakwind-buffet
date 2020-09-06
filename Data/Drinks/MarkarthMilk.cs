/* Author: Roy Fernandez
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent properties of Markarth Milk.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk : Drink, IOrderItem
    {
        /// <summary>
        /// Boolean property for ice in drink
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Backing variable for size of drink.
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets size of drink ordered.
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        /// <summary>
        /// Assigns price of size drink ordered
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known
        /// </exception>
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }             
            }
        }

        /// <summary>
        /// Gives calorie information for size of drink
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known
        /// </exception>
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }               
            }
        }

        /// <summary>
        /// Returns a List of special instructions of drink
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Converts users order to a string
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Markarth Milk");
        }
    }
}
