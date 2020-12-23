using OdeToFood.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.DataAccess.Interface
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
