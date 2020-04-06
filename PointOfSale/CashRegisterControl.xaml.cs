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
/*
 * Author: Dawson Field
 * Class: CashRegisterControl.xaml.cs
 * Purpose: Backend logic for the CashRegisterControl.xaml class
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        public CashRegisterControl()
        {
            InitializeComponent();
        }

        private void OnCashComplete(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            FrameworkElement screen = new MenuItemSelectionControl();
            orderControl.SwapScreen(screen);
            orderControl.CancelOrderButton_Click(this, e);
        }
    }
}
