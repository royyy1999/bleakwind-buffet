/* Author: Roy Fernandez
 * Class: AretinoAppleJuicePOS.xaml.cs
 * Purpose: A class for the Aretino Apple Juice item
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AretinoAppleJuicePOS.xaml
    /// </summary>
    public partial class AretinoAppleJuicePOS : UserControl
    {
        AretinoAppleJuice aj = new AretinoAppleJuice();
        /// <summary>
        /// Initializes the item
        /// </summary>
        public AretinoAppleJuicePOS()
        {
            InitializeComponent();
            DataContext = aj;
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
