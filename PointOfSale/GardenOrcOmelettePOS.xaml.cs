/* Author: Roy Fernandez
 * Class: GardenOrcOmelettePOS.xaml.cs
 * Purpose: A class for the GardenOrcOmelette item
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
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for GardenOrcOmelettePOS.xaml
    /// </summary>
    public partial class GardenOrcOmelettePOS : UserControl
    {
        GardenOrcOmelette go = new GardenOrcOmelette();
        /// <summary>
        /// Initializes the item
        /// </summary>
        public GardenOrcOmelettePOS()
        {
            InitializeComponent();
            DataContext = go;
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
