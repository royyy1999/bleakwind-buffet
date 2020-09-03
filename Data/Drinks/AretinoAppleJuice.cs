/* Author: Roy Fernandez
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent properties of Arentino Apple Juice.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        /// <summary>
        /// Boolean property of ice in drink
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Back variable for size of drink
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets size of drink
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
        /// Assigns price to size of drink 
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.62;
                }
                if (size == Size.Medium)
                {
                    return 0.87;
                }
                if (size == Size.Large)
                {
                    return 1.01;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gives calorie information of size of drink
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 44;
                }
                if (size == Size.Medium)
                {
                    return 88;
                }
                if (size == Size.Large)
                {
                    return 132;
                }
                else
                {
                    throw new NotImplementedException();
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
        /// <returns>Users drink</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Arentino Apple Juice");
        }
    }
}
