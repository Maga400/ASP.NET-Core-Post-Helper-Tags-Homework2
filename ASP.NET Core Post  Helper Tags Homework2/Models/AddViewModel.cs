﻿using ASP.NET_Core_Post__Helper_Tags_Homework2.Entities;

namespace ASP.NET_Core_Post__Helper_Tags_Homework2.Models
{
    public class AddViewModel
    {
        public Food Food { get; set; }

        public AddViewModel() 
        {
        
        }
        public AddViewModel(Food food)
        {
            this.Food = food;
        }
    }
}