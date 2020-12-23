using OdeToFood.Core;
using OdeToFood.Core.Concrete;
using OdeToFood.Core.Enum;
using OdeToFood.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.DataAccess.Concrete
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
             restaurants = new List<Restaurant>()
            {
                new Restaurant
                {
                    Id = 1, Name = "Luigi's Place", Location = "MaryLand", Cuisine = CuisineType.Italian
                },
                new Restaurant
                {
                    Id = 2, Name = "Lou's Place", Location = "Boston", Cuisine = CuisineType.Korean
                }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name).Select(r => r);
        }
    }
}
