﻿/* Author: Roy Fernandez
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent properties of Markarth Milk.
 */
using BleakwindBuffet.Data.Enums;
using DataBleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
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
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.05;
                }
                if (size == Size.Medium)
                {
                    return 1.11;
                }
                if (size == Size.Large)
                {
                    return 1.22;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gives calorie information for size of drink
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 56;
                }
                if (size == Size.Medium)
                {
                    return 72;
                }
                if (size == Size.Large)
                {
                    return 93;
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
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Markarth Milk");
        }
    }
}
