using BleakwindBuffet.Data.Enums;
using DataBleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        public bool Ice { get; set; } = true;

        public bool Lemon { get; set; } = false;

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
                return 0.00;
            }
        }

        public uint Calories
        {
            get
            {
                return (uint)0.00;
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        public override string ToString()
        {
            return (Size.ToString() + " Warrior Water");
        }
    }
}
