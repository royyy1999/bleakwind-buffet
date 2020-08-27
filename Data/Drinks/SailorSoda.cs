using BleakwindBuffet.Data.Enums;
using DataBleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        public bool Ice { get; set; } = true; 

        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                
            }
        }
        public double Price 
        {
            get
            {
                size = Size.Small;
                return size;
            }

            set
            {
                Size.Small = 1.42;
            }
        }

        public uint Calories
        {
            get
            {
               
                
            }

            set
            {
               
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        public override string ToString()
        {
            return "";
        }
    }
}
