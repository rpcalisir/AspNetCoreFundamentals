using OdeToFood.Core.Enum;
using OdeToFood.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Core.Concrete
{
    public class Restaurant : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CuisineType Cuisine{ get; set; }
    }
}
