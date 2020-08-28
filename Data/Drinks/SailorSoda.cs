/* Author: Roy Fernandez
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent properties of the Sailor Soda.
 */
using BleakwindBuffet.Data.Enums;
using DataBleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        /// <summary>
        /// Boolean property for ice in drink
        /// </summary>
        public bool Ice { get; set; } = true; 

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
        /// Backing variable for flavore of drink
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <summary>
        /// Gets and sets flavor of drink ordered
        /// </summary>
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

        /// <summary>
        /// Assigns price to size of drink ordered
        /// </summary>
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

        /// <summary>
        /// Gives calorie information for size of drink.
        /// </summary>
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

        /// <summary>
        /// Returns a List of special instructions of drink.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// Converts users order to a string.
        /// </summary>
        /// <returns>Users drink</returns>
        public override string ToString()
        {
            return (Size.ToString() + " " + Flavor.ToString() + " Sailor Soda");
        }
    }
}
