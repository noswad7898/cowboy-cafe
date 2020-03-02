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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add(new AngryChicken());
        }

        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add(new CowpokeChili());
        }

        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add(new PecosPulledPork());
        }

        private void AddRustlerRibs_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add(new RustlersRibs());
        }

        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add(new TrailBurger());
        }

        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add(new DakotaDoubleBurger());
        }

        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add(new TexasTripleBurger());
        }

        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add(new BakedBeans());
        }

        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add(new ChiliCheeseFries());
        }

        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add(new CornDodgers());
        }

        private void AddPandeCampo_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add(new PanDeCampo());
        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add(new JerkedSoda());
        }

        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add(new CowboyCoffee());
        }

        private void AddAngryTexasTea_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add(new TexasTea());
        }

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add(new Water());
        }
    }
}
