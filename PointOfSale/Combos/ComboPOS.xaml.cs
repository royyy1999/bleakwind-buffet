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
using PointOfSale.Combos;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboPOS.xaml
    /// </summary>
    public partial class ComboPOS : UserControl
    {
        public ComboPOS(Combo item)
        {
            InitializeComponent();
            Combo c = new Combo();
            DataContext = c;
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

        private void EntreeButton_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            EntreeCombo m = new EntreeCombo((Combo)DataContext);
            controlOrder.ScreenSwap(m);
        }

        private void DrinkButton_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            DrinkCombo m = new DrinkCombo((Combo)DataContext);
            controlOrder.ScreenSwap(m);
        }

        private void SideButton_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            SideCombo m = new SideCombo((Combo)DataContext);
            controlOrder.ScreenSwap(m);
        }
    }
}
