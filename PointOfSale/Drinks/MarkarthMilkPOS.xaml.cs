/* Author: Roy Fernandez
 * Class: MarkarthMilkPOS.xaml.cs
 * Purpose: A class for the Markarth Milk item
 */
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MarkarthMilkPOS.xaml
    /// </summary>
    public partial class MarkarthMilkPOS : UserControl
    {
        MarkarthMilk mm;
        /// <summary>
        /// Initializes the item
        /// </summary>
        public MarkarthMilkPOS(MarkarthMilk item)
        {
            InitializeComponent();
            mm = item;
            DataContext = mm;
        }

        /// <summary>
        /// Event handler for the Done button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            MenuSelection m = new MenuSelection();
            controlOrder.ScreenSwap(m);
        }
    }
}
