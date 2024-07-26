using ASP.NET_Core_Post__Helper_Tags_Homework2.Entities;

namespace ASP.NET_Core_Post__Helper_Tags_Homework2.Models
{
    public class UpdateFoodViewModel
    {
        public Food Food { get; set; }
        public UpdateFoodViewModel()
        {

        }
        public UpdateFoodViewModel(Food food)
        {
            Food = food;
        }
    }
}