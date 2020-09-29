/* Author: Roy Fernandez
 * Class: ThugsTBonePOS.xaml.cs
 * Purpose: A class for the Thugs T-Bone item
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ThugsTBonePOS.xaml
    /// </summary>
    public partial class ThugsTBonePOS : UserControl
    {
        /// <summary>
        /// initializes the item
        /// </summary>
        public ThugsTBonePOS()
        {
            InitializeComponent();
        }

        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            MenuSelection m = new MenuSelection();
            controlOrder.ScreenSwap(m);
        }
    }
}
