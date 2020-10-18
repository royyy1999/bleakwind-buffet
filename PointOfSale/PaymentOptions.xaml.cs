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
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        
        public PaymentOptions()
        {
            InitializeComponent();
        }

        private void Cash_Click(object sender, RoutedEventArgs e)
        {
            var controlOrder = this.FindAncestor<MainWindow>();
            Cash c = new Cash();
            controlOrder.ScreenSwap(c);
        }

        private void Card_Click(object sender, RoutedEventArgs e)
        {
           // CardReader.RunCard();
        }
    }
}
