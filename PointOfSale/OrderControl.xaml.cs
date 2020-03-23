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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// creates new order object and prepares complete/cancel order buttons
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();

            var order = new Order();
            this.DataContext = order;

            CompleteOrder.Click += CompleteOrder_Click;
            CancelOrder.Click += CancelOrder_Click;


        }

        

        
        /// <summary>
        /// ???
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelection_Click(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// handler for cancel order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// hadler for complete order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        public void OnMenuItemSelectionButtonClicked (object sander, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }


        /// <summary>
        /// swaps item selection with item customization ui
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
    }
}
