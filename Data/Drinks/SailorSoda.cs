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
                flavor = value;
            }
        }
        public double Price 
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.42;
                }
                if (size == Size.Medium)
                {
                    return 1.74;
                }
                if (size == Size.Large)
                {
                    return 2.07;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }        
        }

        public uint Calories
        {
            get
            {
                 if(size == Size.Small)
                {
                    return 117;
                }           
                if(size == Size.Medium)
                {
                    return 153;
                }
                if(size == Size.Large)
                {
                    return 205;
                }
                 else
                {
                    throw new NotImplementedException();
                }
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
            return (Size.ToString() + " " + Flavor.ToString() + " Sailor Soda");
        }
    }
}
