/* Author: Roy Fernandez
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent properties of the Smokehouse Skeleton.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// Boolean property for sausage on order
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// Boolean property for eggs on order
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Boolean property for hash browns on order
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// Boolean property for pancakes on order
        /// </summary>
        public bool Pancake { get; set; } = true;


        /// <summary>
        /// Returns a List of special instructions of order
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// Name of entree ordered
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
