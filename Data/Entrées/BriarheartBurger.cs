﻿/* Author: Roy Fernandez
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent properties of the Briarheart Burger.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 6.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 743;

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

        /// <summary>
        /// Returns a List of special instructions on the burger.
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
                return ("Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.");
            }
        }

        /// <summary>
        /// Converts users order to a string.
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
