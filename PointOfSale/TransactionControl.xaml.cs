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
using PointOfSale.ExtensionMethods;
using CowboyCafe.Data;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public TransactionControl()
        {
            InitializeComponent();
        }

        private void OnCreditSelect(object sender, RoutedEventArgs e)
        {
            CardTerminal cardTerminal = new CardTerminal();
            double total;
            if(DataContext is Order order)
            {
                total = order.Total;
                ResultCode result = cardTerminal.ProcessTransaction(total);
                if (result == ResultCode.Success)
                {
                    PrintRecipt(true);
                }
                if (result == ResultCode.ReadError)
                {
                    ReadErrorPopup.IsOpen = true;
                    return;
                }
                if (result == ResultCode.UnknownErrror)
                {
                    UnknownErrorPopup.IsOpen = true;
                    return;
                }
                if (result == ResultCode.InsufficentFunds)
                {
                    InsufficientFunds.IsOpen = true;
                    return;
                }
            }
            
        }

        private void OnCashSelect(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            FrameworkElement screen = new CashRegisterControl();
            orderControl.SwapScreen(screen);

        }

        private void OnCancelSelect(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            FrameworkElement screen = new MenuItemSelectionControl();
            orderControl.SwapScreen(screen);
            orderControl.CancelOrderButton_Click(this, e);
        }

        public void PrintRecipt(bool card)
        {
            ReceiptPrinter printer = new ReceiptPrinter();
            DateTime now = DateTime.Now;

            if(DataContext is Order order)
            {
                printer.Print("Order Number: \t" + order.OrderNumber.ToString());
                printer.Print("\n");
                printer.Print(now.ToString());
                printer.Print("\n\n");

                foreach (IOrderItem item in order.Items)
                {
                    printer.Print(item.ToString());
                    printer.Print("\t");
                    printer.Print(item.Price.ToString());
                    printer.Print("\n\t");
                    StringBuilder builder = new StringBuilder();
                    foreach(string SpecialInstructions  in order.SpecialInstructions)
                    {
                        builder.Append(SpecialInstructions);
                    }
                    string result = builder.ToString();
                    printer.Print(result);
                    printer.Print("\n");
                }

                printer.Print("\n");
                printer.Print("Subtotal: \t");
                printer.Print(order.Subtotal.ToString());
                printer.Print("\n");
                printer.Print("Total: \t");
                printer.Print(order.Total.ToString());
                printer.Print("\n");

                if (card)
                {
                    printer.Print("Payment Method: Card\n");
                }
                if (!card)
                {
                    printer.Print("PaymentMethod: Cash");
                }
            }
        }
    }
}
