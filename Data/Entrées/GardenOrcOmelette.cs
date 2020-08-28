using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// Boolean property for broccoli on omelette
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Boolean property for mushrooms on omelette
        /// </summary>
        public bool Mushrooms{ get; set; } = true;

        /// <summary>
        /// Boolean property for tomatos on omelette
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Boolean property for cheddar on omelette
        /// </summary>
        public bool Cheddar { get; set; } = true;


        /// <summary>
        /// Returns a List of special instructions for omelette.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }
        
        /// <summary>
        /// Converts users order to a string
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
