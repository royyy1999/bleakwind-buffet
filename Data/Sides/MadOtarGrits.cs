/* Author: Roy Fernandez
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent properties of the cheesy grits.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side, IOrderItem
    {
        /// <summary>
        /// Assigns the price to the size ordered.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known
        /// </exception>
        public override double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 1.22;
                    case Size.Medium: return 1.58;
                    case Size.Large: return 1.93;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }                
            }
        }

        /// <summary>
        /// Gives calorie information for the size ordered.
        /// </summary>
        /// /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known
        /// </exception>
        public override uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 105;
                    case Size.Medium: return 142;
                    case Size.Large: return 179;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }                
            }
        }

        /// <summary>
        /// Returns a List of special instructions of the order.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }


        /// <summary>
        /// Converts users order to a string.
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Mad Otar Grits");
        }
    }
}
