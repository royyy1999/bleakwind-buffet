/* Author: Roy Fernandez
 * Class: Drink.cs
 * Purpose: A base class representing common properties for drinks
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public abstract class Drink
    {
        /// <summary>
        /// Backing variable for size of drink
        /// </summary>
        public Size size = Size.Small;

        /// <summary>
        /// Size of the drink
        /// </summary>
        public virtual Size Size {

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
        /// Price of the drink
        /// </summary>
        /// <value>In US dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
