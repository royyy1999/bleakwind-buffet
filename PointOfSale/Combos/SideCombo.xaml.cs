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
using BleakwindBuffet.Data;

namespace PointOfSale.Combos
{
    /// <summary>
    /// Interaction logic for SideCombo.xaml
    /// </summary>
    public partial class SideCombo : UserControl
    {
        Combo combo = new Combo();
        public SideCombo(Combo c)
        {
            InitializeComponent();
            combo = c;
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
            combo.Side = item;
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
            combo.Side = item;
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
            combo.Side = item;
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
            combo.Side = item;
            if (DataContext is OrderMenu ord) ord.Add(item);

            controlOrder.ScreenSwap(bb);
        }

    }
}
