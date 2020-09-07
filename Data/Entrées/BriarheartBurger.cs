/* Author: Roy Fernandez
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent properties of the Briarheart Burger.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 6.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 743;

        /// <summary>
        /// Boolean property for bun on burger
        /// </summary>
        public bool Bun{ get; set; } = true;

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
        /// Returns a List of special instructions on the burger.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }

        /// <summary>
        /// Converts users order to a string.
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
