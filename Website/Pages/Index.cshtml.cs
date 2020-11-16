/* Author: Roy Fernandez
 * Class: Index.cshtml.cs
 * Purpose: Handles the website index page
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// List of food items 
        /// </summary>
        public IEnumerable<IOrderItem> OrderItems { get; protected set; }

        /// <summary>
        /// Term being searched for
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// List of entree items
        /// </summary>
        public List<IOrderItem> Entree { get; set; }

        /// <summary>
        /// List of side items
        /// </summary>
        public List<IOrderItem> Side { get; set; }

        /// <summary>
        /// List of drink items
        /// </summary>
        public List<IOrderItem> Drink { get; set; }

        /// <summary>
        /// Handles the functions on index page
        /// </summary>
        /// <param name="SearchItem">term being search</param>
        /// <param name="foodType">type of item</param>
        /// <param name="PriceMin">minimum price</param>
        /// <param name="PriceMax">maximum price</param>
        /// <param name="CalMin">minimum amount of calories</param>
        /// <param name="CalMax">maximum amount of calories</param>
        public void OnGet(string SearchItem, IEnumerable<string> foodType, double? PriceMin, double? PriceMax, int? CalMin, int? CalMax)
        {
            OrderItems = Menu.FullMenu();
            SearchTerms = SearchItem;
            List<IOrderItem> filtered = new List<IOrderItem>();

            // Search 
            if (SearchTerms != null)
            {
                string[] word = SearchTerms.Split(' ');
                foreach (string s in word)
                {
                    OrderItems = OrderItems.Where(items => items.ToString() != null && items.ToString().Contains(s, StringComparison.InvariantCultureIgnoreCase) ||
                    items.Description != null && items.Description.Contains(s, StringComparison.InvariantCultureIgnoreCase));
                    filtered.AddRange(OrderItems);
                    OrderItems = Menu.FullMenu();
                }
                OrderItems = filtered;
            }

            // Category Filter
            if (foodType != null && foodType.Count() != 0)
            {
                OrderItems = OrderItems.Where(items =>
                    items is Entree && foodType.Contains("Entree") ||
                    items is Side && foodType.Contains("Side") ||
                    items is Drink && foodType.Contains("Drink")
                    );
            }

            // Calories Filter
            if (CalMin == null && CalMax != null)
            {
                OrderItems = OrderItems.Where(item => item.Calories <= CalMax);
            }
            if (CalMax == null && CalMin != null)
            {
                OrderItems = OrderItems.Where(item => item.Calories >= CalMin);
            }
            if (CalMin != null && CalMax != null)
            {
                OrderItems = OrderItems.Where(item => item.Calories >= CalMin && item.Calories <= CalMax);
            }

            // Price Filter
            if (PriceMin == null && PriceMax != null)
            {
                OrderItems = OrderItems.Where(item => item.Price <= PriceMax);
            }
            if (PriceMax == null && PriceMin != null)
            {
                OrderItems = OrderItems.Where(item => item.Price >= PriceMin);
            }
            if (PriceMin != null && PriceMax != null)
            {
                OrderItems = OrderItems.Where(item => item.Price >= PriceMin && item.Price <= PriceMax);
            }

            Entree = new List<IOrderItem>();
            Side = new List<IOrderItem>();
            Drink = new List<IOrderItem>();

            foreach(IOrderItem item in OrderItems)
            {
                if(item is Entree)
                {
                    Entree.Add(item);
                }
                if (item is Side)
                {
                    Side.Add(item);
                }
                if (item is Drink)
                {
                    Drink.Add(item);
                }
            }
        }
    }
}
