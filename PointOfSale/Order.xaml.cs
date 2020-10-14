/* Author: Roy Fernandez
 * Class: Order.xaml.cs
 * Purpose: A class for the Order list
 */
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : UserControl
    {
        OrderMenu ord;
        /// <summary>
        /// Initializes order
        /// </summary>
        public Order()
        {
            InitializeComponent();
            if (DataContext is OrderMenu o)
                ord = o;
            
        }


        private void Finish_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
