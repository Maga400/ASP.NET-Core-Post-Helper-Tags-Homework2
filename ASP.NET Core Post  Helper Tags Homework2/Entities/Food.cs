using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_Post__Helper_Tags_Homework2.Entities
{
    public class Food
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Is Requred")]
        [MinLength(5, ErrorMessage = "Minimum name should be 5")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Description is required")]
        [MinLength(10, ErrorMessage = "Minimum description should be 10")]
        public string Description { get; set; }
        public int Price { get; set; }        
        public int Discount { get; set; }
        public Food() 
        {
        
        }
        public Food(int id,string name, string description, int price, int discount)
        {
            Name = name;
            Description = description;
            Price = price;
            Discount = discount;
            Id = id;
        }

    }
}
