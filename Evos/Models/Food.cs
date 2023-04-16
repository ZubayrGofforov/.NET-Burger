using Evos.Enums;

namespace Evos.Models
{
    public class Food
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public FoodType FoodType { get; set; }
    }
}
