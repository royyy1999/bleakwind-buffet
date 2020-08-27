using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
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
                    return 0.42;
                }
                if (size == Size.Medium)
                {
                    return 0.76;
                }
                if (size == Size.Large)
                {
                    return 0.96;
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
                    return 77;
                }
                if (size == Size.Medium)
                {
                    return 89;
                }
                if (size == Size.Large)
                {
                    return 100;
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
                return instructions;
            }
        }

        public override string ToString()
        {
            return (Size.ToString() + " Dragonborn Waffle Fries");
        }
    }
}
