using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone
    {
        /// <summary>
        /// Gets the price of the T-Bone
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// Gets the calories of the T-Bone
        /// </summary>
        public uint Calories => 982;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
