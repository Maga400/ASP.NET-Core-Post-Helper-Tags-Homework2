using ASP.NET_Core_Post__Helper_Tags_Homework2.Entities;
using ASP.NET_Core_Post__Helper_Tags_Homework2.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Post__Helper_Tags_Homework2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper mapper;

        public HomeController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public static List<Food> Foods { get; set; } = new List<Food>()
        {
            new Food(1,"Fanta","this is a drink",2,5),
            new Food(2,"Chipsim","this is bad food",3,3),
            new Food(3,"Chicken","this is very taisty food",10,20),
        };
        public IActionResult Index()
        {
            var foodViewModel = new FoodViewModel(Foods);
            return View(foodViewModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var addViewModel = new AddViewModel()
            {
                Food = new Food()
            };

            return View(addViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Random random = new Random();
                vm.Food.Id = random.Next(100, 1000);
                Foods.Add(vm.Food);
                return RedirectToAction("Index");
            }
            return View(vm);

        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            //var food = Foods.FirstOrDefault(f => f.Id == id);

            //return food != null ? 
            //    View(new UpdateFoodViewModel
            //    {
            //        Food = food
            //    }) : 
            //RedirectToAction("Index");


            var food = Foods.FirstOrDefault(f => f.Id == id);

            if (food != null)
            {
                var updateViewModel = new UpdateFoodViewModel()
                {
                    Food = food,
                };
                return View(updateViewModel);

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(UpdateFoodViewModel vm)
        {
            var foodFromDb = Foods.FirstOrDefault(f => f.Id == vm.Food.Id);

            //mapper.Map(vm, foodFromDb);

            foodFromDb.Name = vm.Food.Name;
            foodFromDb.Description = vm.Food.Description;
            foodFromDb.Price = vm.Food.Price;
            foodFromDb.Discount = vm.Food.Discount;


            return RedirectToAction("Index");

        }

        public IActionResult DeleteFood(int id)
        {
            var food = Foods.SingleOrDefault(f => f.Id == id);
            if (food != null)
            {
                Foods.Remove(food);
            }

            return RedirectToAction("Index");
        }


    }
}
