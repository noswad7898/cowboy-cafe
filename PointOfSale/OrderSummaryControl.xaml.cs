
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
        // Initialize component
        public OrderSummaryControl()
        {
            InitializeComponent();
        }
        // Deletes menu items when x button is pressed
        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if(DataContext is Order order)
            {
                var button = sender as Button;
                order.Remove(button.DataContext as IOrderItem);
            }
        }
        /// <summary>
        /// allows existing order list items to be reopened to edit its properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(OrderListView.SelectedItem == null)
            {
                return;
            }
            
            if (sender is ListBox list)
            {
                if (list.SelectedItem is IOrderItem item)
                {
                    list.SelectedItem = null;
                    if(item is AngryChicken ac)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        var screen = new AngryChickenCustomization(DataContext);
                        screen.DataContext = ac;
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is CowpokeChili cpc)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        var screen = new CowpokeChiliCustomization(DataContext);
                        screen.DataContext = cpc;
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is DakotaDoubleBurger ddb)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        var screen = new DakotaDoubleCustomization(DataContext);
                        screen.DataContext = ddb;
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is PecosPulledPork ppp)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        var screen = new PecosPulledPorkCustomization(DataContext);
                        screen.DataContext = ppp;
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is RustlersRibs rr)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        var screen = new RustlersRibsCustomization();
                        screen.DataContext = rr;
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is TexasTripleBurger ttb)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        var screen = new TexasTripleCustomization(DataContext);
                        screen.DataContext = ttb;
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is TrailBurger tb)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        var screen = new TrailBurgerCustomization(DataContext);
                        screen.DataContext = tb;
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is CowboyCoffee cc)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        var screen = new CowboyCoffeeCustomization(DataContext);
                        screen.DataContext = cc;
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is JerkedSoda js)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        var screen = new JerkedSodaCustomization(DataContext);
                        screen.DataContext = js;
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is TexasTea tt)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        var screen = new TexasTeaCustomization(DataContext);
                        screen.DataContext = tt;
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is Water w)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        var screen = new WaterCustomization(DataContext);
                        screen.DataContext = w;
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is BakedBeans bb)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        var screen = new SideSizeCustomization(DataContext);
                        screen.DataContext = bb;
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is ChiliCheeseFries ccf)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        var screen = new SideSizeCustomization(DataContext);
                        screen.DataContext = ccf;
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is CornDodgers cd)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        var screen = new SideSizeCustomization(DataContext);
                        screen.DataContext = cd;
                        orderControl?.SwapScreen(screen);
                    }
                    if (item is PanDeCampo pdc)
                    {
                        var orderControl = this.FindAncestor<OrderControl>();
                        var screen = new SideSizeCustomization(DataContext);
                        screen.DataContext = pdc;
                        orderControl?.SwapScreen(screen);
                    }
                }
            }
        }
    }
}