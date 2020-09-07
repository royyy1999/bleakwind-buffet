/* Author: Roy Fernandez
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent properties of Thugs T-Bone.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the T-Bone
        /// </summary>
        public override double Price => 6.44;

        /// <summary>
        /// Gets the calories of the T-Bone
        /// </summary>
        public override uint Calories => 982;

        /// <summary>
        /// Returns an empty list.
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
        /// Name of entree ordered
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
