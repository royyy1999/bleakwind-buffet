/* Author: Roy Fernandez
 * Class: WarriorWater.xaml.cs
 * Purpose: A class for the Warrior Water item
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for WarriorWaterPOS.xaml
    /// </summary>
    public partial class WarriorWaterPOS : UserControl
    {
        WarriorWater ww;
        /// <summary>
        /// Initializes the item
        /// </summary>
        public WarriorWaterPOS(WarriorWater item)
        {
            InitializeComponent();
            ww = item;
            DataContext = ww;
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
