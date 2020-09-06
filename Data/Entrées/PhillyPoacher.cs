/* Author: Roy Fernandez
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent properties of the Philly Poacher.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// Boolean property for sirloin 
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// Boolean property for onions
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Boolean property for roll
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// Returns a List of special instrucitons of sirloin
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// Name of the entree ordered
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
