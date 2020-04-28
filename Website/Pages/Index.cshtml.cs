using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;
/// <summary>
/// Author: Dawson Field
/// Class: Index.cshtml.cs
/// Description: 
/// </summary>
namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; }

        [BindProperty]
        public string[] Types { get; set; }
        
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
            //this.CaloriesMin = CaloriesMin;
            //this.CaloriesMax = CaloriesMax;
            //this.PriceMin = PriceMin;
            //this.PriceMax = PriceMax;
            SearchTerms = Request.Query["SearchTerms"];
            Items = MenuDatabase.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = MenuDatabase.FilterByPrice(Items, PriceMin, PriceMax);
            Items = MenuDatabase.FilterByType(Items, Types);
            Items = MenuDatabase.Search(SearchTerms);
        }

        public void OnPost()
        {
            //this.CaloriesMin = CaloriesMin;
            //this.CaloriesMax = CaloriesMax;
            //this.PriceMin = PriceMin;
            //this.PriceMax = PriceMax;
            //SearchTerms = Request.Query["SearchTerms"];
            Items = MenuDatabase.Search(SearchTerms);
            Items = MenuDatabase.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = MenuDatabase.FilterByPrice(Items, PriceMin, PriceMax);
            Items = MenuDatabase.FilterByType(Items, Types);
            
        }
    }
}
