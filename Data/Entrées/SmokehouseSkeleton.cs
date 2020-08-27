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

        public bool SausageLink { get; set; } = true;

        public bool Egg { get; set; } = true;

        public bool HashBrowns { get; set; } = true;

        public bool Pancake { get; set; } = true;



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

        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
