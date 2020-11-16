/* Author: Roy Fernandez
 * Class: Drink.cs
 * Purpose: A base class representing common properties for drinks
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public abstract class Drink : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Backing variable for size of drink
        /// </summary>
        public Size size = Size.Small;

        /// <summary>
        /// Size of the drink
        /// </summary>
        public virtual Size Size {

            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Name { get => this.ToString(); }
        /// <summary>
        /// Price of the drink
        /// </summary>
        /// <value>In US dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Returns a string of the description of the item
        /// </summary>
        /// <return>A string of the description</return>
        public abstract string Description { get; }
    }
}
