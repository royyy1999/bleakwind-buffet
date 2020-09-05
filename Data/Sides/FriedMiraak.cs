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
    public class FriedMiraak
    {
        /// <summary>
        /// Backing variable for size of order.
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets size of the side.
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
        /// Assigns the price to the size of the side ordered.
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
        public uint Calories
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
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
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
