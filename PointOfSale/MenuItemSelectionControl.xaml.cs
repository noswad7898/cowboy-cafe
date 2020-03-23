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
using System.Linq;
using PointOfSale.CustomizationScreens;
using CowboyCafe.PointOfSale.ExtensionMethods;


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
            // Button clicks

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

        /// <summary>
        /// Handler for angry chicken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            AngryChicken temp = new AngryChicken();
            if (DataContext is Order order)
            {
                var screen = new AngryChickenCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// Handler for cowpoke chili
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            CowpokeChili temp = new CowpokeChili();
            if (DataContext is Order order)
            {
                var screen = new CowpokeChiliCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// Handler for Pecos Pulled pork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            PecosPulledPork temp = new PecosPulledPork();
            if (DataContext is Order order)
            {
                var screen = new PecosPulledPorkCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// Hander for Rustlers ribs 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlerRibs_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            RustlersRibs temp = new RustlersRibs();
            if (DataContext is Order order)
            {
                var screen = new RustlersRibsCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// handler for trail burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            TrailBurger temp = new TrailBurger();
            if (DataContext is Order order)
            {
                var screen = new TrailBurgerCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// handler for dakota double burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            DakotaDoubleBurger temp = new DakotaDoubleBurger();
            if (DataContext is Order order)
            {
                var screen = new DakotaDoubleBurgerCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// handler for texastripleburger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            TexasTripleBurger temp = new TexasTripleBurger();
            if (DataContext is Order order)
            {
                var screen = new TexasTripleBurgerCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// handler for baked beans
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
           BakedBeans temp = new BakedBeans();
            if (DataContext is Order order)
            {
                var screen = new BakedBeansCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// handler for chili cheese fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            ChiliCheeseFries temp = new ChiliCheeseFries();
            if (DataContext is Order order)
            {
                var screen = new ChiliCheeseFriesCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// handler for corn dodgers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            CornDodgers temp = new CornDodgers();
            if (DataContext is Order order)
            {
                var screen = new CornDodgersCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// handler for pan de campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPandeCampo_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            PanDeCampo temp = new PanDeCampo();
            if (DataContext is Order order)
            {
                var screen = new PandeCampoCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// handler for jerked soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            JerkedSoda temp = new JerkedSoda();
            if (DataContext is Order order)
            {
                var screen = new JerkedSodaCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// handler for cowboy coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            CowboyCoffee temp = new CowboyCoffee();
            if (DataContext is Order order)
            {
                var screen = new CowboyCoffeeCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// handler for texas tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            TexasTea temp = new TexasTea();
            if (DataContext is Order order)
            {
                var screen = new TexasTeaCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
        /// <summary>
        /// handler for water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            Water temp = new Water();
            if (DataContext is Order order)
            {
                var screen = new WaterCustomization();
                screen.DataContext = temp;
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
    }
}
