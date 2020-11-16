/* Author: Roy Fernandez
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent properties of the cajun fries.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side, IOrderItem
    {
        /// <summary>
        /// Assigns the price of the size ordered.
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
                    case Size.Small: return 0.42;
                    case Size.Medium: return 0.76;
                    case Size.Large: return 0.96;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }               
            }
        }

        /// <summary>
        /// Gives calorie information for size ordered.
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
                    case Size.Small: return 77;
                    case Size.Medium: return 89;
                    case Size.Large: return 100;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }             
            }
        }

        /// <summary>
        /// Returns a List of special instructions of order.
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
                return ("Crispy fried potato waffle fries.");
            }
        }

        /// <summary>
        /// Converts users order to a string
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Dragonborn Waffle Fries");
        }
    }
}
