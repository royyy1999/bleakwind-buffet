using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
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
                    return 0.93;
                }
                if (size == Size.Medium)
                {
                    return 1.28;
                }
                if (size == Size.Large)
                {
                    return 1.82;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        //}

        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 41;
                }
                if (size == Size.Medium)
                {
                    return 52;
                }
                if (size == Size.Large)
                {
                    return 73;
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
            return (Size.ToString() + " Vokun Salad");
        }
    }
}
