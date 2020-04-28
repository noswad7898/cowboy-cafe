using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using CowboyCafe.Data.Drinks;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data.Sides;

using CowboyCafe.Data.Enums;
using System.Linq;
/// <summary>
/// Author: Dawson Field
/// Class: Manu.cs
/// About: Refactors all menu items in the data project into lists for each item type and a list for all items
/// </summary>
namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// List of all entree items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            var entrees = new List<IOrderItem>();
            AngryChicken angryChicken = new AngryChicken();
            entrees.Add(angryChicken);
            CowpokeChili cowpokeChili = new CowpokeChili();
            entrees.Add(cowpokeChili);
            PecosPulledPork pecosPulledPork = new PecosPulledPork();
            entrees.Add(pecosPulledPork);
            RustlersRibs rustlersRibs = new RustlersRibs();
            entrees.Add(rustlersRibs);
            TrailBurger trailBurger = new TrailBurger();
            entrees.Add(trailBurger);
            DakotaDoubleBurger dakotaDoubleBurger = new DakotaDoubleBurger();
            entrees.Add(dakotaDoubleBurger);
            TexasTripleBurger texasTripleBurger = new TexasTripleBurger();
            entrees.Add(texasTripleBurger);
            return entrees;
        }
        /// <summary>
        /// lis tof all side items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            var sides = new List<IOrderItem>();
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                BakedBeans bakedBeans = new BakedBeans();
                bakedBeans.Size = size;
                sides.Add(bakedBeans);
                ChiliCheeseFries chiliCheeseFries = new ChiliCheeseFries();
                chiliCheeseFries.Size = size;
                sides.Add(chiliCheeseFries);
                CornDodgers cornDodgers = new CornDodgers();
                cornDodgers.Size = size;
                sides.Add(cornDodgers);
                PanDeCampo panDeCampo = new PanDeCampo();
                panDeCampo.Size = size;
                sides.Add(panDeCampo);
            }
            return sides;
        }
        /// <summary>
        /// list of all drink items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            var drinks = new List<IOrderItem>();
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                CowboyCoffee cowboyCoffee = new CowboyCoffee();
                cowboyCoffee.Size = size;
                drinks.Add(cowboyCoffee);
                JerkedSoda jerkedSoda = new JerkedSoda();
                jerkedSoda.Size = size;
                drinks.Add(jerkedSoda);
                TexasTea texasTea = new TexasTea();
                texasTea.Size = size;
                drinks.Add(texasTea);
                Water water = new Water();
                water.Size = size;
                drinks.Add(water);
            }
            return drinks;
        }
        /// <summary>
        /// list of all menu items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            var all = new List<IOrderItem>();
            AngryChicken angryChicken = new AngryChicken();
            all.Add(angryChicken);
            CowpokeChili cowpokeChili = new CowpokeChili();
            all.Add(cowpokeChili);
            PecosPulledPork pecosPulledPork = new PecosPulledPork();
            all.Add(pecosPulledPork);
            RustlersRibs rustlersRibs = new RustlersRibs();
            all.Add(rustlersRibs);
            TrailBurger trailBurger = new TrailBurger();
            all.Add(trailBurger);
            DakotaDoubleBurger dakotaDoubleBurger = new DakotaDoubleBurger();
            all.Add(dakotaDoubleBurger);
            TexasTripleBurger texasTripleBurger = new TexasTripleBurger();
            all.Add(texasTripleBurger);
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                BakedBeans bakedBeans = new BakedBeans();
                bakedBeans.Size = size;
                all.Add(bakedBeans);
                ChiliCheeseFries chiliCheeseFries = new ChiliCheeseFries();
                chiliCheeseFries.Size = size;
                all.Add(chiliCheeseFries);
                CornDodgers cornDodgers = new CornDodgers();
                cornDodgers.Size = size;
                all.Add(cornDodgers);
                PanDeCampo panDeCampo = new PanDeCampo();
                panDeCampo.Size = size;
                all.Add(panDeCampo);

                CowboyCoffee cowboyCoffee = new CowboyCoffee();
                cowboyCoffee.Size = size;
                all.Add(cowboyCoffee);
                JerkedSoda jerkedSoda = new JerkedSoda();
                jerkedSoda.Size = size;
                all.Add(jerkedSoda);
                TexasTea texasTea = new TexasTea();
                texasTea.Size = size;
                all.Add(texasTea);
                Water water = new Water();
                water.Size = size;
                all.Add(water);
            }
            return (all);

        }


        private static List<IOrderItem> menuItems = MenuDatabase();

        static List<IOrderItem> MenuDatabase()
        {
            foreach (Entree item in Menu.Entrees())
            {
                menuItems.Add(item);
            }
            foreach (Side item in Menu.Sides())
            {
                menuItems.Add(item);
            }
            foreach (Drink item in Menu.Drinks())
            {
                menuItems.Add(item);
            }
            return menuItems;
        }

        /// <summary>
        /// Search Function
        /// </summary>
        /// <param name="terms"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return Menu.CompleteMenu();
            foreach (IOrderItem item in Menu.CompleteMenu())
            {
                if (item != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> All { get { return Menu.CompleteMenu(); } }
        /// <summary>
        /// Filter by item type 
        /// </summary>
        /// <param name="items"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> items, string[] type)
        {
            if (type == null) return items;

            if (type.Contains("Side"))
            {
                items.Concat(Menu.Sides());
            }

            if (type.Contains("Entree"))
            {
                items.Concat(Menu.Sides());
            }

            if (type.Contains("Drink"))
            {
                items.Concat(Menu.Drinks());
            }
            return items;
        }
        /// <summary>
        /// filter by calories
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menuItems, uint? min, uint? max)
        {
            // if min and max are null return all
            if (min == null && max == null) return menuItems;

            var results = new List<IOrderItem>();

            //only a maximum is specified
            if (min == null)
            {
                foreach (IOrderItem item in menuItems)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            //only a minimum is specified
            if (max == null)
            {
                foreach (IOrderItem item in menuItems)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            // both parameters are provided
            foreach (IOrderItem item in menuItems)
            {
                if (item.Calories >= min && item.Calories <= max) results.Add(item);
            }
            return results;
        }
        /// <summary>
        /// Filter by price
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menuItems, double? min, double? max)
        {
            // if min and max are null return all
            if (min == null && max == null) return menuItems;

            var results = new List<IOrderItem>();

            //only a maximum is specified
            if (min == null)
            {
                foreach (IOrderItem item in menuItems)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            //only a minimum is specified
            if (max == null)
            {
                foreach (IOrderItem item in menuItems)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            // both parameters are provided
            foreach (IOrderItem item in menuItems)
            {
                if (item.Price >= min && item.Calories <= max) results.Add(item);
            }
            return results;
        }

    }
}
