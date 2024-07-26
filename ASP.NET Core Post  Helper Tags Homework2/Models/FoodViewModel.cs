using ASP.NET_Core_Post__Helper_Tags_Homework2.Entities;
using System.Collections.Generic;

namespace ASP.NET_Core_Post__Helper_Tags_Homework2.Models
{
    public class FoodViewModel
    {
        public List<Food> Foods { get; set; }
        public FoodViewModel()
        {

        }
        public FoodViewModel(List<Food> foods)
        {
            Foods = foods;
        }
    }
}