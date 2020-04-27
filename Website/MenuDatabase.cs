using CowboyCafe.Data;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data.Sides;
using CowboyCafe.Data.Drinks;
using CowboyCafe.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, string type)
        {
            if (type == null) return items;

            if (type.Contains("Side"))
            {
                items.Add(Menu.Sides());
            }

            if (type.Contains("Entree"))
            {
                items.Add(Menu.Sides());
            }

            if (type.Contains("Drink"))
            {
                items.Add(Menu.Drinks());
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
    }
}
