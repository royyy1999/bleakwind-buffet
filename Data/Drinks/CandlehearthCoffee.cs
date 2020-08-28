/* Author: Roy Fernandez
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent properties of CandlehearthCoffe.
 */
using BleakwindBuffet.Data.Enums;
using DataBleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        /// <summary>
        /// Boolean property for ice in drink
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Backing variable for size of drink
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets and sets size of drink ordered
        /// </summary>
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

        /// <summary>
        /// Assigns price to size of drink
        /// </summary>
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

        /// <summary>
        /// Gives calorie information for size of drink 
        /// </summary>
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

        /// <summary>
        /// Boolean property for if theres room for cream in the coffee.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Boolean property for a decaf coffee.
        /// </summary>
        public bool Decaf { get; set; } = false; 

        /// <summary>
        /// Returns a List of special instructions of coffee
        /// </summary>
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

        /// <summary>
        /// Type of coffee ordered by user
        /// </summary>
        /// <returns>Users coffee</returns>
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
