using CowboyCafe.Data;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data.Sides;
using CowboyCafe.Data.Drinks;
using CowboyCafe.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// Author: Dawson Field
/// Class: MenuDatabase
/// Function: Holds code for filtering and searching menu items on the website
/// </summary>
namespace Website
{
    public static class MenuDatabase
    {
        private static List<IOrderItem> menuItems = new List<IOrderItem>();
        

        static MenuDatabase()
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
            foreach(IOrderItem item in Menu.CompleteMenu())
            {
                if(item != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
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
        public static IEnumerable<IOrderItem> FilterByCalories (IEnumerable<IOrderItem> menuItems, uint? min, uint? max)
        {
            // if min and max are null return all
            if (min == null && max == null) return menuItems;

            var results = new List<IOrderItem>();

            //only a maximum is specified
            if(min == null)
            {
                foreach(IOrderItem item in menuItems)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            //only a minimum is specified
            if(max == null)
            {
                foreach(IOrderItem item in menuItems)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            // both parameters are provided
            foreach(IOrderItem item in menuItems)
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
