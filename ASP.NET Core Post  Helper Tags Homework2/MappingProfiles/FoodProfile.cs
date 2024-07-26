using ASP.NET_Core_Post__Helper_Tags_Homework2.Entities;
using ASP.NET_Core_Post__Helper_Tags_Homework2.Models;
using AutoMapper;

namespace ASP.NET_Core_Post__Helper_Tags_Homework2.MappingProfiles
{
    public class FoodProfile : Profile
    {
        public FoodProfile()
        {
            CreateMap<Food, UpdateFoodViewModel>()
                .ForPath(x => x.Food, opt => opt.MapFrom(x => x)).ReverseMap();

            CreateMap<Food, Food>();
        }
    }
}
