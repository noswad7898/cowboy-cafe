
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
using CashRegister;
/*
 * Author: Dawson Field
 * Class: BillControl.xaml.cs
 * Purpose: Backend logic for the BillControl.xaml class
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for BillControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
    {
        /// <summary>
        /// denomination property
        /// </summary>
        public static readonly DependencyProperty DenominationProperty =
           DependencyProperty.Register(
               "Denomination",
               typeof(Bills),
               typeof(BillControl),
               new PropertyMetadata(Bills.One));
        /// <summary>
        /// bills property
        /// </summary>
        public Bills Denomination
        {
            get { return (Bills)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }
        /// <summary>
        /// quantity property
        /// </summary>
        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register(
                "Quantity",
                typeof(int),
                typeof(BillControl),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );
        /// <summary>
        /// quantity int
        /// </summary>
        public int Quantity
        {
            get => (int)GetValue(QuantityProperty);
            set => SetValue(QuantityProperty, value);
        }
        /// <summary>
        /// initializecomponent
        /// </summary>
        public BillControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// increase quantity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }
        /// <summary>
        /// decrease quantity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity--;
        }
    }
}
