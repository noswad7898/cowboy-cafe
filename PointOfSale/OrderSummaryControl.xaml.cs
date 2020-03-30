
/*
 * Author: Zachery Brunner
 * Edited: Dawson Field
 * Class: OrderControl.xaml.cs
 * Purpose: Backend logic for the receipt for the program
 */
using CowboyCafe.Data;
using PointOfSale.ExtensionMethods;
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
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data.Drinks;
using CowboyCafe.Data.Sides;
using PointOfSale.CustomizationScreens;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if(DataContext is Order order)
            {
                var button = sender as Button;
                order.Remove(button.DataContext as IOrderItem);
            }
        }

        private void OrderListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(OrderListView.SelectedItem == null)
            {
                return;
            }
            string itemString = OrderListView.SelectedItem.ToString();
            if (itemString.Contains("RustlersRibs"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                RustlersRibs item = e.AddedItems[0] as RustlersRibs;
                if(DataContext is Order order)
                {
                    var screen = new RustlersRibsCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }
            if (itemString.Contains("AngryChicken"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                AngryChicken item = e.AddedItems[0] as AngryChicken;
                if (DataContext is Order order)
                {
                    var screen = new AngryChickenCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }
            if (itemString.Contains("CowpokeChili"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                CowpokeChili item = e.AddedItems[0] as CowpokeChili;
                if (DataContext is Order order)
                {
                    var screen = new CowpokeChiliCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }
        }
    }
}