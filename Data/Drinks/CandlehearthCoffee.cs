/* Author: Roy Fernandez
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent properties of CandlehearthCoffe.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
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
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }             
              
            }
        }

        /// <summary>
        /// Gives calorie information for size of drink 
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
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
                
            }
        }

        private bool roomForCream = false;
        /// <summary>
        /// Boolean property for if theres room for cream in the coffee.
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
                OnPropertyChanged("RoomForCream");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool decaf = false;
        /// <summary>
        /// Boolean property for a decaf coffee.
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                OnPropertyChanged("Decaf");
                OnPropertyChanged("Name");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Returns a List of special instructions of coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Leave room for cream");
                return instructions;
            }
        }

        /// <summary>
        /// Description of the item
        /// </summary>
        public override string Description
        {
            get
            {
                return ("Fair trade, fresh ground dark roast coffee.");
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
