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
using BleakwindBuffet.Data;
using System.Runtime.InteropServices.ComTypes;

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
            var order = (OrderMenu)DataContext;
            var o = CardReader.RunCard(order.Total);

            if(o == CardTransactionResult.Approved)
            {
                PrintReciept();
                var p = this.FindAncestor<MainWindow>();
            }

            if(o == CardTransactionResult.Declined)
            {
                MessageBox.Show("Sorry, your card was declined");
            }
            if(o == CardTransactionResult.IncorrectPin)
            {
                MessageBox.Show("Incorrect pin, try again");
            }
            if (o == CardTransactionResult.InsufficientFunds)
            {
                MessageBox.Show("Insufficent funds, try another card");
            }
            if (o == CardTransactionResult.ReadError)
            {
                MessageBox.Show("Error reading card");
            }
        }

        public void PrintReciept()
        {
            var order = (OrderMenu)DataContext;

            RecieptPrinter.PrintLine("Order Number: " + order.Number.ToString());
            foreach(var item in order.list)
            {
                RecieptPrinter.PrintLine(item.ToString() + "....$" + item.Price);
                foreach (var n in item.SpecialInstructions) RecieptPrinter.PrintLine(n);
                RecieptPrinter.PrintLine("Subtotal....$" + order.Subtotal.ToString());
                RecieptPrinter.PrintLine("Tax....$" + order.Tax.ToString());
                RecieptPrinter.PrintLine("Payment Method Used.... Card$" + order.Subtotal.ToString());
                RecieptPrinter.CutTape();
            }
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

