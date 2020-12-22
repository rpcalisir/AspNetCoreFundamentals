using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

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

        public ListModel(IConfiguration config)
        {
            this.config = config;
        }
        public void OnGet()
        {
            Message = config["Message"];
        }
    }
}
