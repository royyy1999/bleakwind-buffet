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

namespace PointOfSale.Combos
{
    /// <summary>
    /// Interaction logic for DrinkCombo.xaml
    /// </summary>
    public partial class DrinkCombo : UserControl
    {
        Combo combo = new Combo();
        public DrinkCombo(Combo c)
        {
            InitializeComponent();
            combo = c;
        }

        /// <summary>
        /// Event handler for the Sailor Soda button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void SailorSoda_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            SailorSoda item = new SailorSoda();
            SailorSodaPOS bb = new SailorSodaPOS(item);
            combo.Drink = item;
            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

        /// <summary>
        /// Event handler for the Markarth Milk button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void MarkarthMilk_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            MarkarthMilk item = new MarkarthMilk();
            MarkarthMilkPOS bb = new MarkarthMilkPOS(item);
            combo.Drink = item;
            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

        /// <summary>
        /// Event handler for the Aretino Apple Juice button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void AretinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            AretinoAppleJuice item = new AretinoAppleJuice();
            AretinoAppleJuicePOS bb = new AretinoAppleJuicePOS(item);
            combo.Drink = item;
            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

        /// <summary>
        /// Event handler for the Candlehearth Coffee button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void CandlehearthCoffee_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            CandlehearthCoffee item = new CandlehearthCoffee();
            CandlehearthCoffeePOS bb = new CandlehearthCoffeePOS(item);
            combo.Drink = item;
            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

        /// <summary>
        /// Event handler for the Warrior Water button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void WarriorWater_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            WarriorWater item = new WarriorWater();
            WarriorWaterPOS bb = new WarriorWaterPOS(item);
            combo.Drink = item;
            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }
    }
}
