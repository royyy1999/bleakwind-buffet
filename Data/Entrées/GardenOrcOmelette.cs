/* Author: Roy Fernandez
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent properties of the Garden Orc Omelette.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 404;

        private bool broccoli = true;
        /// <summary>
        /// Boolean property for broccoli on omelette
        /// </summary>
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }
            set
            {
                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool mushrooms = true; 
        /// <summary>
        /// Boolean property for mushrooms on omelette
        /// </summary>
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool tomato = true;
        /// <summary>
        /// Boolean property for tomatos on omelette
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool cheddar = true;
        /// <summary>
        /// Boolean property for cheddar on omelette
        /// </summary>
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        /// <summary>
        /// Returns a List of special instructions for omelette.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli)
                {
                    instructions.Add("Hold broccoli");

                }
                if (!Mushrooms)
                {
                    instructions.Add("Hold mushrooms");

                }
                if (!Tomato)
                {
                    instructions.Add("Hold tomato");

                }
                if (!Cheddar)
                {
                    instructions.Add("Hold cheddar");

                }
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
                return ("Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.");
            }
        }

        /// <summary>
        /// Converts users order to a string
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
