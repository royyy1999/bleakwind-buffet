/* Author: Roy Fernandez
 * Class: Combo.cs
 * Purpose: Allows the user to order a combo of menu items
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Combo()
        {

        }

        private Entree entree;
        public Entree Entree
        {
            get
            {
                return entree;
            }

            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private Side side;
        public Side Side
        {
            get
            {
                return side;
            }

            set
            {
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private Drink drink;
        public Drink Drink
        {
            get
            {
                return drink;
            }

            set
            {
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private Size size = Size.Small;
        public Size Size
        {
            set
            {
                Side.Size = value;
                Drink.Size = value;
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
            
        }

        /// <summary>
        /// Price of the item
        /// </summary>
        /// <value>In US dollars</value>
        public double Price
        {
            get
            {
                var price = 0.0;
                if(Entree != null)
                {
                    price += Entree.Price;
                }
                if (Drink != null)
                {
                    price += Drink.Price;
                }
                if (Side != null)
                {
                    price += Side.Price;
                }
                return price;
            }
        }

        /// <summary>
        /// Calories of the item
        /// </summary>
        public uint Calories
        {
            get
            {
                uint cal = 0;
                if (Entree != null)
                {
                    cal += Entree.Calories;
                }
                if (Drink != null)
                {
                    cal += Drink.Calories;
                }
                if (Side != null)
                {
                    cal += Side.Calories;
                }
                return cal;
            }
        }

        /// <summary>
        /// Special Instructions to prepare the item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> list = new List<string>();

                list.Add(Entree.ToString());
                list.AddRange(Entree.SpecialInstructions);

                list.Add(Side.ToString());
                list.AddRange(Side.SpecialInstructions);

                list.Add(Drink.ToString());
                list.AddRange(Drink.SpecialInstructions);

                return list;

            }
        }

    }
}
