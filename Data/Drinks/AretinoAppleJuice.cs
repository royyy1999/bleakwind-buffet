/* Author: Roy Fernandez
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent properties of Arentino Apple Juice.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink, IOrderItem, INotifyPropertyChanged
    { 

        private bool ice = false;
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
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Assigns price to size of drink 
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
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }                  
            }
        }

        /// <summary>
        /// Gives calorie information of size of drink
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
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        /// <summary>
        /// Returns a List of special instructions of drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Converts users order to a string
        /// </summary>
        /// <returns>Users drink</returns>
        public override string ToString()
        {
            return (Size.ToString() + " Aretino Apple Juice");
        }
    }
}
