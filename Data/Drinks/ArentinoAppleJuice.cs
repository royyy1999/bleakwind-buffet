using BleakwindBuffet.Data.Enums;
using DataBleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatBleakwindBuffet.Data.Drinks
{
    public class ArentinoAppleJuice
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
                    return 0.62;
                }
                if (size == Size.Medium)
                {
                    return 0.87;
                }
                if (size == Size.Large)
                {
                    return 1.01;
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
                    return 44;
                }
                if (size == Size.Medium)
                {
                    return 88;
                }
                if (size == Size.Large)
                {
                    return 132;
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
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        public override string ToString()
        {
            return (Size.ToString() + " Arentino Apple Juice");
        }
    }
}
