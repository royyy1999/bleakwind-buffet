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

    public class VokunSalad
    {
        /// <summary>
        /// Backing variable for size of salad.
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets the size of the salad
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
        /// Assigns the price to each of the the salad sizes.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known
        /// </exception>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.93;
                }
                if (size == Size.Medium)
                {
                    return 1.28;
                }
                if (size == Size.Large)
                {
                    return 1.82;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Assigns calories to each salad size.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known
        /// </exception>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 41;
                }
                if (size == Size.Medium)
                {
                    return 52;
                }
                if (size == Size.Large)
                {
                    return 73;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns a List of special instructions of the order. 
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
        /// Converts the users order to a string.
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Vokun Salad");
        }
    }
}
