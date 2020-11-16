/* Author: Roy Fernandez
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent properties of the hash brown pancakes.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak : Side, IOrderItem
    {
        /// <summary>
        /// Assigns the price to the size of the side ordered.
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
                    case Size.Small: return 1.78;
                    case Size.Medium: return 2.01;
                    case Size.Large: return 2.88;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }              
            }
        }

        /// <summary>
        /// Gives calorie information for size of the side ordered.
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
                    case Size.Small: return 151;
                    case Size.Medium: return 236;
                    case Size.Large: return 306;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }                
            }
        }

        /// <summary>
        /// Returns a List of special instructions of the side
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
                return ("Perfectly prepared hash brown pancakes.");
            }
        }

        /// <summary>
        /// Converts order to a string
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Fried Miraak");
        }
    }
}
