/* Author: Roy Fernandez
 * Class: VokunSaladPOS.xaml.cs
 * Purpose: A class for the Vokun Salad item
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
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for VokunSaladPOS.xaml
    /// </summary>
    public partial class VokunSaladPOS : UserControl
    {
        VokunSalad vs = new VokunSalad();
        /// <summary>
        /// Initializes the item
        /// </summary>
        public VokunSaladPOS()
        {
            InitializeComponent();
            DataContext = vs;
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
