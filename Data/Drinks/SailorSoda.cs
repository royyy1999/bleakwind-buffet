/* Author: Roy Fernandez
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent properties of the Sailor Soda.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
    {

        private bool ice = true;
        /// <summary>
        /// Boolean property of ice in drink
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }

            set
            {
                ice = value;
                OnPropertyChanged("Ice");
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
                OnPropertyChanged("Flavor");
            }
        }

        /// <summary>
        /// Assigns price to size of drink ordered
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known
        /// </exception>
        public override double Price 
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }              
            }        
        }

        /// <summary>
        /// Gives calorie information for size of drink.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known
        /// </exception>
        public override uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }              
            }
        }

        /// <summary>
        /// Returns a List of special instructions of drink.
        /// </summary>
        public override List<string> SpecialInstructions
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
