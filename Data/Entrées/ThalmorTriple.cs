﻿/* Author: Roy Fernandez
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent properties of the Thalmor Triple.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 943;

        private bool bun = true;
        /// <summary>
        /// Boolean property for bun on burger
        /// </summary>
        public bool Bun 
        {
            get
            {
                return bun;
            }
            set
            {
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// Boolean property for ketchup on burger
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool mustard = true;
        /// <summary>
        /// Boolean property for mustard on burger
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool pickle = true;
        /// <summary>
        /// Boolean property for pickles on burger
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool cheese = true;
        /// <summary>
        /// Boolean property for cheese on burger
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool tomato = true;
        /// <summary>
        /// Boolean property for tomatos on burger
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

        private bool lettuce = true;
        /// <summary>
        /// Boolean property for lettuce on burger
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool mayo = true;
        /// <summary>
        /// Boolean property for mayo on burger
        /// </summary>
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool bacon = true;
        /// <summary>
        /// Boolean property for bacon on burger
        /// </summary>
        public bool Bacon
        {
            get
            {
                return bacon;
            }
            set
            {
                bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool egg = true;
        /// <summary>
        /// Boolean property for egg on burger
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Returns a List of special instructions of burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun)
                {
                    instructions.Add("Hold bun");
 
                }
                if (!Ketchup)
                {
                    instructions.Add("Hold ketchup");

                }
                if (!Mustard)
                {
                    instructions.Add("Hold mustard");

                }
                if (!Pickle)
                {
                    instructions.Add("Hold pickle");

                }
                if (!Cheese)
                {
                    instructions.Add("Hold cheese");
                }
                if (!Tomato)
                {
                    instructions.Add("Hold tomato");
                }
                if (!Lettuce)
                {
                    instructions.Add("Hold lettuce");

                }
                if (!Mayo)
                {
                    instructions.Add("Hold mayo");

                }
                if (!Mayo)
                {
                    instructions.Add("Hold mayo");

                }
                if (!Bacon)
                {
                    instructions.Add("Hold bacon");

                }
                if (!Egg)
                {
                    instructions.Add("Hold egg");

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
                return ("Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.");
            }
        }

        /// <summary>
        /// Converts users order to a string.
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}

