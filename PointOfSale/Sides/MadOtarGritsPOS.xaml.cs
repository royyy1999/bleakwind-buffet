﻿/* Author: Roy Fernandez
 * Class: MadOtarGritsPOS.xaml.cs
 * Purpose: A class for the Mad Otar Grits item
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
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MadOtarGritsPOS.xaml
    /// </summary>
    public partial class MadOtarGritsPOS : UserControl
    {
        MadOtarGrits mg;
        /// <summary>
        /// Initializes the item
        /// </summary>
        public MadOtarGritsPOS(MadOtarGrits item)
        {
            InitializeComponent();
            mg = item;
            DataContext = mg;
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
