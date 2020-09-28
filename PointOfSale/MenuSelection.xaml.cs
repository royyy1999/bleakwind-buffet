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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
        /// <summary>
        /// Initializes buttons
        /// </summary>
        public MenuSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The event handler for the item selected
        /// </summary>
        public event EventHandler<EventHandlerSelector> itemSelected;

        /// <summary>
        /// Event handler for the Briarheart Burger button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        void BriarheartBurger_Click(object sender, RoutedEventArgs e)
        {
            BriarheartBurger itemFood = new BriarheartBurger();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }

        /// <summary>
        /// Event handler for the Double Draugr button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        void DoubleDraugr_Click(object sender, RoutedEventArgs e)
        {
            DoubleDraugr itemFood = new DoubleDraugr();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }

        /// <summary>
        /// Event handler for the Thalmor Triple
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
         void ThalmorTriple_Click(object sender, RoutedEventArgs e)
        {
            ThalmorTriple itemFood = new ThalmorTriple();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }

        /// <summary>
        /// Event handler for the Smokehouse Skeleton button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void SmokehouseSkeleton_Click(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton itemFood = new SmokehouseSkeleton();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }

        /// <summary>
        /// Event handler for the Garden Orc Omelette button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void GardenOrcOmelette_Click(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette itemFood = new GardenOrcOmelette();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }

        /// <summary>
        /// Event handler for the Philly Poacher button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void PhillyPoacher_Click(object sender, RoutedEventArgs e)
        {
            PhillyPoacher itemFood = new PhillyPoacher();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }

        /// <summary>
        /// Event handler for the Thugs TBone button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void ThugsTBone_Click(object sender, RoutedEventArgs e)
        {
            ThugsTBone itemFood = new ThugsTBone();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }

        /// <summary>
        /// Event handler for the Sailor Soda button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void SailorSoda_Click(object sender, RoutedEventArgs e)
        {
            SailorSoda itemFood = new SailorSoda();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }

        /// <summary>
        /// Event handler for the Markarth Milk button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void MarkarthMilk_Click(object sender, RoutedEventArgs e)
        {
            MarkarthMilk itemFood = new MarkarthMilk();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }

        /// <summary>
        /// Event handler for the Aretino Apple Juice button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void AretinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice itemFood = new AretinoAppleJuice();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }

        /// <summary>
        /// Event handler for the Candlehearth Coffee button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void CandlehearthCoffee_Click(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee itemFood = new CandlehearthCoffee();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }

        /// <summary>
        /// Event handler for the Warrior Water button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void WarriorWater_Click(object sender, RoutedEventArgs e)
        {
            WarriorWater itemFood = new WarriorWater();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }

        /// <summary>
        /// Event handler for the Vokun Salad button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void VokunSalad_Click(object sender, RoutedEventArgs e)
        {
            VokunSalad itemFood = new VokunSalad();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }

        /// <summary>
        /// Event handler for the Fried Miraak button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void FriedMiraak_Click(object sender, RoutedEventArgs e)
        {
            FriedMiraak itemFood = new FriedMiraak();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }

        /// <summary>
        /// Event handler for the Mad Otar Grits button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void MadOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            MadOtarGrits itemFood = new MadOtarGrits();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }

        /// <summary>
        /// Event handler for the Dragonborn Waffle Fries button
        /// </summary>
        /// <param name="sender">What triggered this event</param>
        /// <param name="e">The parameters of this event</param>
        private void DragonbornWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries itemFood = new DragonbornWaffleFries();
            itemSelected?.Invoke(this, new EventHandlerSelector() { item = itemFood });
        }
    }
}
