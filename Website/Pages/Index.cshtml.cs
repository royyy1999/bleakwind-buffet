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
        public IEnumerable<IOrderItem> OrderItems { get; protected set; }

        public string SearchTerms { get; set; }

        public List<IOrderItem> Entree { get; set; }

        public List<IOrderItem> Side { get; set; }

        public List<IOrderItem> Drink { get; set; }
        public IndexModel()
        {

        }

        public void OnGet(string SearchItem, IEnumerable<string> foodType, double? PriceMin, double? PriceMax, int? CalMin, int? CalMax)
        {
            SearchTerms = SearchItem;
            OrderItems = Menu.FullMenu();
            OrderItems = Menu.Search(OrderItems, SearchItem);
            OrderItems = Menu.FilterByCategory(OrderItems, foodType);
            OrderItems = Menu.FilterByPrice(OrderItems, PriceMin, PriceMax);
            OrderItems = Menu.FilterByCalories(OrderItems, CalMin, CalMax);

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
