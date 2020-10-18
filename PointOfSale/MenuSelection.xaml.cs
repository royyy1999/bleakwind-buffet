/* Author: Roy Fernandez
 * Class: MenuSelection.xaml.cs
 * Purpose: Allow user to select an item from the menu
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
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
         
          // Find a way to connect menu selection class to order
        /// <summary>
        /// Initializes buttons
        /// </summary>
        public MenuSelection()
        {
            InitializeComponent();    
        }

        
        /// <summary>
        /// Event handler for the Briarheart Burger button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void BriarheartBurger_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            BriarheartBurger item = new BriarheartBurger();
            BriarheartBurgerPOS bb = new BriarheartBurgerPOS(item);

            if(DataContext is OrderMenu ord) ord.Add(item);               

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

            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
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

            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

        /// <summary>
        /// Event handler for the Vokun Salad button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void VokunSalad_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            VokunSalad item = new VokunSalad();
            VokunSaladPOS bb = new VokunSaladPOS(item);

            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

        /// <summary>
        /// Event handler for the Fried Miraak button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void FriedMiraak_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            FriedMiraak item = new FriedMiraak();
            FriedMiraakPOS bb = new FriedMiraakPOS(item);

            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

        /// <summary>
        /// Event handler for the Mad Otar Grits button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void MadOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            MadOtarGrits item = new MadOtarGrits();
            MadOtarGritsPOS bb = new MadOtarGritsPOS(item);

            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

        /// <summary>
        /// Event handler for the Dragonborn Waffle Fries button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void DragonbornWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            DragonbornWaffleFries item = new DragonbornWaffleFries();
            DragonbornWaffleFriesPOS bb = new DragonbornWaffleFriesPOS(item);

            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

        private void Combo_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            Combo item = new Combo();
            ComboPOS c = new ComboPOS(item);

            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(c);
        }
    }
}
