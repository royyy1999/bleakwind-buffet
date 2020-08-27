using BleakwindBuffet.Data.Enums;
using DataBleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        public bool Ice { get; set; } = false;

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

        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.75;
                }
                if (size == Size.Medium)
                {
                    return 1.25;
                }
                if(size == Size.Large)
                {
                    return 1.75;
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
                if (size == Size.Small)
                {
                    return 7;
                }
                if (size == Size.Medium)
                {
                    return 10;
                }
                if (size == Size.Large)
                {
                    return 20;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        public bool RoomForCream { get; set; } = false;

        public bool Decaf { get; set; } = false; 

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        public override string ToString()
        {
            if (!Decaf)
            {
                return (Size.ToString() + " Candlehearth Coffee");
            }
            else
            {
                return (Size.ToString() + " Decaf Candlehearth Coffee");
            }
            
        }
    }
}
