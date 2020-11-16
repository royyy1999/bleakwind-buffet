/* Author: Roy Fernandez
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent properties of the salad.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{

    public class VokunSalad : Side, IOrderItem
    {
        /// <summary>
        /// Assigns the price to each of the the salad sizes.
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
                    case Size.Small: return 0.93;
                    case Size.Medium: return 1.28;
                    case Size.Large: return 1.82;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }            
            }
        }

        /// <summary>
        /// Assigns calories to each salad size.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known
        /// </exception>
        public override uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 41;
                    case Size.Medium: return 52;
                    case Size.Large: return 73;
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
        /// Description of the item
        /// </summary>
        public override string Description
        {
            get
            {
                return ("A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.");
            }
        }

        /// <summary>
        /// Converts the users order to a string.
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Vokun Salad");
        }
    }
}
