/* Author: Roy Fernandez
 * Class: Side.cs
 * Purpose: A base class representing common properties for sides
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Backing variable for size of drink
        /// </summary>
        public Size size = Size.Small; 
        /// <summary>
        /// Size of the side
        /// </summary>
        public virtual Size Size
        {
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

        public string Name { get => ToString(); }
        /// <summary>
        /// Price of the side
        /// </summary>
        /// <value>In US dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Returns a string of the description of the item
        /// </summary>
        /// <return>A string of the description</return>
        public abstract string Description { get; }
    }
}
