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
using BleakwindBuffet.Data;


namespace PointOfSale.Combos
{
    /// <summary>
    /// Interaction logic for EntreeCombo.xaml
    /// </summary>
    public partial class EntreeCombo : UserControl
    {
        Combo combo = new Combo();
        public EntreeCombo(Combo c)
        {
            InitializeComponent();
            combo = c;
        }

        private void BriarheartBurger_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            BriarheartBurger item = new BriarheartBurger();
            BriarheartBurgerPOS bb = new BriarheartBurgerPOS(item);
            combo.Entree = item;
            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

        /// <summary>
        /// Event handler for the Double Draugr button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void DoubleDraugr_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            DoubleDraugr item = new DoubleDraugr();
            DoubleDraugrPOS bb = new DoubleDraugrPOS(item);
            combo.Entree = item;
            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

        /// <summary>
        /// Event handler for the Thalmor Triple
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void ThalmorTriple_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            ThalmorTriple item = new ThalmorTriple();
            ThalmorTriplePOS bb = new ThalmorTriplePOS(item);
            combo.Entree = item;
            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

        /// <summary>
        /// Event handler for the Smokehouse Skeleton button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void SmokehouseSkeleton_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            SmokehouseSkeleton item = new SmokehouseSkeleton();
            SmokehouseSkeletonPOS bb = new SmokehouseSkeletonPOS(item);
            combo.Entree = item;
            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

        /// <summary>
        /// Event handler for the Garden Orc Omelette button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void GardenOrcOmelette_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            GardenOrcOmelette item = new GardenOrcOmelette();
            GardenOrcOmelettePOS bb = new GardenOrcOmelettePOS(item);
            combo.Entree = item;
            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

        /// <summary>
        /// Event handler for the Philly Poacher button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void PhillyPoacher_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            PhillyPoacher item = new PhillyPoacher();
            PhillyPoacherPOS bb = new PhillyPoacherPOS(item);
            combo.Entree = item;
            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

        /// <summary>
        /// Event handler for the Thugs TBone button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void ThugsTBone_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            ThugsTBone item = new ThugsTBone();
            ThugsTBonePOS bb = new ThugsTBonePOS(item);
            combo.Entree = item;
            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }
    }
}
