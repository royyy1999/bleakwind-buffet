using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories => 784;

        public bool Sirloin { get; set; } = true;

        public bool Onion { get; set; } = true;

        public bool Roll { get; set; } = true;


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

        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
