/* Author: Roy Fernandez
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent properties of the Double Draugr.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 7.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories => 843;

        /// <summary>
        /// Boolean property for bun on burger
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Boolean property for ketchup on burger
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Boolean property for mustard on burger
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Boolean property for pickles on burger
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Boolean property for cheese on burger
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Boolean property for tomatos on burger
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Boolean property for lettuce on burger
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Boolean property for mayo on burger
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Returns a List of special instructions of burger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
        }

        /// <summary>
        /// Converts users order to a string
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
