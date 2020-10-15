/* Author: Roy Fernandez
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent properties of the Smokehouse Skeleton.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 602;

        private bool sausagelink = true;
        /// <summary>
        /// Boolean property for sausage on order
        /// </summary>
        public bool SausageLink
        {
            get
            {
                return sausagelink;
            }
            set
            {
                sausagelink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool egg = true;
        /// <summary>
        /// Boolean property for eggs on order
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

        private bool hashbrowns = true;
        /// <summary>
        /// Boolean property for hash browns on order
        /// </summary>
        public bool HashBrowns
        {
            get
            {
                return hashbrowns;
            }
            set
            {
                hashbrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool pancake = true;
        /// <summary>
        /// Boolean property for pancakes on order
        /// </summary>
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        /// <summary>
        /// Returns a List of special instructions of order
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink)
                {
                    instructions.Add("Hold sausage");

                }
                if (!Egg)
                {
                    instructions.Add("Hold eggs");

                }
                if (!HashBrowns)
                {
                    instructions.Add("Hold hash browns");

                }
                if (!Pancake)
                {
                    instructions.Add("Hold pancakes");

                }
                return instructions;
            }
        }

        /// <summary>
        /// Name of entree ordered
        /// </summary>
        /// <returns>Users order</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
