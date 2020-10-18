/* Author: Roy Fernandez
 * Class: Order.xaml.cs
 * Purpose: A class for the Order list
 */
using BleakwindBuffet.Data;
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : UserControl
    {
       
        /// <summary>
        /// Initializes order
        /// </summary>
        public Order()
        {
            InitializeComponent(); 
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is OrderMenu ord)
            {
                ord = new OrderMenu();
                var i = this.FindAncestor<MainWindow>();
                i.DataContext = ord;
                PaymentOptions p = new PaymentOptions();
                i.ScreenSwap(p);
            }
          
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is OrderMenu ord)
            {
                ord = new OrderMenu();
                var i = this.FindAncestor<MainWindow>();
                i.DataContext = ord;
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is OrderMenu ord)
                ord.Remove((IOrderItem)((Button)sender).DataContext);
        }

        private void ItemChange(object sender, SelectionChangedEventArgs e)
        {
            FrameworkElement sc;
            var o = this.FindAncestor<MainWindow>();

            if(DataContext is OrderMenu ord)
            {
                if(sender is ListBox box)
                {
                    if(box.SelectedItem is IOrderItem item)
                    {
                        if(item is BriarheartBurger bb)
                        {
                            sc = new BriarheartBurgerPOS(bb);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                        else if (item is DoubleDraugr dd)
                        {
                            sc = new DoubleDraugrPOS(dd);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                        else if (item is GardenOrcOmelette go)
                        {
                            sc = new GardenOrcOmelettePOS(go);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                        else if (item is PhillyPoacher pp)
                        {
                            sc = new PhillyPoacherPOS(pp);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                        else if (item is SmokehouseSkeleton sm)
                        {
                            sc = new SmokehouseSkeletonPOS(sm);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                        else if (item is ThalmorTriple tt)
                        {
                            sc = new ThalmorTriplePOS(tt);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                        else if (item is ThugsTBone tb)
                        {
                            sc = new ThugsTBonePOS(tb);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                        else if (item is AretinoAppleJuice aj)
                        {
                            sc = new AretinoAppleJuicePOS(aj);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                        else if (item is CandlehearthCoffee cc)
                        {
                            sc = new CandlehearthCoffeePOS(cc);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                        else if (item is MarkarthMilk mm)
                        {
                            sc = new MarkarthMilkPOS(mm);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                        else if (item is SailorSoda ss)
                        {
                            sc = new SailorSodaPOS(ss);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                        else if (item is WarriorWater ww)
                        {
                            sc = new WarriorWaterPOS(ww);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                        else if (item is DragonbornWaffleFries df)
                        {
                            sc = new DragonbornWaffleFriesPOS(df);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                        else if (item is FriedMiraak fm)
                        {
                            sc = new FriedMiraakPOS(fm);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                        else if (item is MadOtarGrits mo)
                        {
                            sc = new MadOtarGritsPOS(mo);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                        else if (item is VokunSalad vs)
                        {
                            sc = new VokunSaladPOS(vs);
                            sc.DataContext = item;
                            o?.ScreenSwap(sc);
                        }
                    }
                }
            }
        }
    }
}
