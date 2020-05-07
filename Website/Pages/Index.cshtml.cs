using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data.Sides;
using CowboyCafe.Data.Enums;
using CowboyCafe.Data.Drinks;
/// <summary>
/// Author: Dawson Field
/// Class: Index.cshtml.cs
/// Description: 
/// </summary>
namespace Website.Pages
{
#nullable enable
    public class IndexModel : PageModel
    {
        public IEnumerable<IOrderItem>? Items { get; protected set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty]
        public string? SearchTerms { get; set; }

        [BindProperty]
        public string[]? Types { get; set; }
        
        [BindProperty]
        public uint? CaloriesMin { get; set; }
        [BindProperty]
        public uint? CaloriesMax { get; set; }

        [BindProperty]
        public double? PriceMin { get; set; }
        [BindProperty]
        public double? PriceMax { get; set; }

        public void OnGet()
        {
            // Search by name
            if (SearchTerms != null)
            {
                Items = Items.Where(IOrderItem => { return Items.ToString() != null && Items.ToString().Contains(SearchTerms, StringComparison.CurrentCultureIgnoreCase); });
            }


            // filter by calories if only min is provided
            if(CaloriesMin != null && CaloriesMax == null)
            {
                Items = Items.Where(IOrderItem => IOrderItem.Calories >= CaloriesMin);
            }
            // if only max is provided
            if (CaloriesMin == null && CaloriesMax != null)
            {
                Items = Items.Where(IOrderItem => IOrderItem.Calories <= CaloriesMax);
            }
            // if both are provided
            if (CaloriesMin != null && CaloriesMax != null)
            {
                Items = Items.Where(IOrderItem => IOrderItem.Calories <= CaloriesMax && IOrderItem.Calories >= CaloriesMin);
            }


            // filter by price if only min is provided
            if (PriceMin != null && PriceMax == null)
            {
                Items = Items.Where(IOrderItem => IOrderItem.Price >= PriceMin);
            }
            // if only max is provided
            if (PriceMin == null && PriceMax != null)
            {
                Items = Items.Where(IOrderItem => IOrderItem.Price <= PriceMax);
            }
            // if both are provided
            if (PriceMin != null && PriceMax != null)
            {
                Items = Items.Where(IOrderItem => IOrderItem.Price <= PriceMax && IOrderItem.Price >= PriceMin);
            }


            // filter by type
            if(Types != null)
            {
                if (Types.Contains("Entree"))
                {
                    Items = Items.Where(IOrderItem => IOrderItem is Entree);
                }
                if (Types.Contains("Side"))
                {
                    Items = Items.Where(IOrderItem => IOrderItem is Side);
                }
                if (Types.Contains("Drink"))
                {
                    Items = Items.Where(IOrderItem => IOrderItem is Drink);
                }
            }
            
        }
    }
}
