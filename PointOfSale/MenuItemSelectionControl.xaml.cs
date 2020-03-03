using CowboyCafe.Data;
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

            //Entrees
            AddCowpokeChili.Click += AddCowpokeChili_Click;
            AddRustlersRibs.Click += AddRustlerRibs_Click;
            AddPecosPulledPork.Click += AddPecosPulledPork_Click;
            AddTrailBurger.Click += AddTrailBurger_Click;
            AddDakotaDoubleBurger.Click += AddDakotaDoubleBurger_Click;
            AddTexasTripleBurger.Click += AddTexasTripleBurger_Click;
            AddAngryChicken.Click += AddAngryChicken_Click;

            //Sides
            AddCornDodgers.Click += AddCornDodgers_Click;
            AddChiliCheeseFries.Click += AddChiliCheeseFries_Click;
            AddPandeCampo.Click += AddPandeCampo_Click;
            AddBakedBeans.Click += AddBakedBeans_Click;

            //Drinks
            AddJerkedSoda.Click += AddJerkedSoda_Click;
            AddCowboyCoffee.Click += AddCowboyCoffee_Click;
            AddTexasTea.Click += AddTexasTea_Click;
            AddWater.Click += AddWater_Click;

        }

        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            //AngryChicken temp = new AngryChicken();
            if(DataContext is Order order)
            {
                order.Add(new AngryChicken());
            }
        }

        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            CowpokeChili temp = new CowpokeChili();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            PecosPulledPork temp = new PecosPulledPork();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddRustlerRibs_Click(object sender, RoutedEventArgs e)
        {
            RustlersRibs temp = new RustlersRibs();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            TrailBurger temp = new TrailBurger();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            DakotaDoubleBurger temp = new DakotaDoubleBurger();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            TexasTripleBurger temp = new TexasTripleBurger();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            BakedBeans temp = new BakedBeans();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            ChiliCheeseFries temp = new ChiliCheeseFries();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            CornDodgers temp = new CornDodgers();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddPandeCampo_Click(object sender, RoutedEventArgs e)
        {
            PanDeCampo temp = new PanDeCampo();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda temp = new JerkedSoda();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            CowboyCoffee temp = new CowboyCoffee();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            TexasTea temp = new TexasTea();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            Water temp = new Water();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }
    }
}
