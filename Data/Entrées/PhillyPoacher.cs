﻿/* Author: Roy Fernandez
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent properties of the Philly Poacher.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 784;

        private bool sirloin = true;
        /// <summary>
        /// Boolean property for sirloin 
        /// </summary>
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }
            set
            {
                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool onion = true;
        /// <summary>
        /// Boolean property for onions
        /// </summary>
        public bool Onion
        {
            get
            {
                return onion;
            }
            set
            {
                onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool roll = true;
        /// <summary>
        /// Boolean property for roll
        /// </summary>
        public bool Roll
        {
            get
            {
                return roll;
            }
            set
            {
                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Returns a List of special instrucitons of sirloin
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin)
                {
                    instructions.Add("Hold sirloin");

                }
                if (!Onion)
                {
                    instructions.Add("Hold onions");

                }
                if (!Roll)
                {
                    instructions.Add("Hold roll");

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
                return ("Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.");
            }
        }

        /// <summary>
        /// Name of the entree ordered
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
