using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core.Concrete;
using OdeToFood.DataAccess.Interface;

namespace OdeToFood.Pages.Restaurants
{
    /// <summary>
    /// ListModel acts like Controller
    /// Contains models(properties)
    /// (Razor Page(List) acts like View)
    /// </summary>
    public class ListModel : PageModel
    {
        public string Message { get; set; }
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;
        public IEnumerable<Restaurant> Restaurants { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }
        public void OnGet()
        {
            Restaurants = restaurantData.GetAll();
            Message = config["Message"];
        }
    }
}
