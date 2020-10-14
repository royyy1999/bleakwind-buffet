using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Collections;

namespace BleakwindBuffet.Data
{
    public class OrderMenu : ICollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        private static int nextOrderNumber = 1;

        public event PropertyChangedEventHandler PropertyChanged;

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public List<IOrderItem> list = new List<IOrderItem>();

        public OrderMenu() 
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

        public void Add(IOrderItem item)
        {
            list.Add(item);
            item.PropertyChanged += CollectionChangedListener;

            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        public void Remove(IOrderItem item)
        {
            int index = list.FindIndex(i => i == item);
            var del = list.Remove(item);

            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, index));
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));

        }

        void CollectionChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            }

            if(e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
        public void Clear()
        {
            foreach(IOrderItem item in list)
            {
                item.PropertyChanged -= CollectionChangedListener;
            }
            list.Clear();
        }

        public bool Contains(IOrderItem item)
        {
            return list.Contains(item);
        }

        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)list).GetEnumerator();
        }

        IEnumerator<IOrderItem> IEnumerable<IOrderItem>.GetEnumerator()
        {
            return list.GetEnumerator();   
        }

        bool ICollection<IOrderItem>.Remove(IOrderItem item)
        {
            throw new NotImplementedException();
        }

        private double salestax = 0.12;
        public double SalesTax
        {
            get
            {
                return salestax;
            }
            set
            {
                salestax = value;
            }
        }

        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach (IOrderItem item in list)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        public double Tax
        {
            get
            {
                return Subtotal * SalesTax;
            }
        }
        
        public double Total
        {
            get
            {
                return Subtotal + Tax;
            }
        }


        public uint Calories
        {
            get
            {
                uint cal = 0;
                foreach(IOrderItem item in list)
                {
                    cal += item.Calories;
                }
                return cal;
            }
        }
        
        public int Number { get; }

        public int Count => list.Count;

        public bool IsReadOnly => false;
    }
}
