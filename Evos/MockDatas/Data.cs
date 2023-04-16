using Evos.Models;

namespace Evos.MockDatas
{
    public class Data
    {
        public static List<Food> Foods = new List<Food>()
        {
            new Food() {Name = "Mol go'shtli lavash mini", Price = 21000, FoodType = Enums.FoodType.Lavash},
            new Food() {Name = "Mol go'sht va pishloqli lavash mini", Price = 24000, FoodType = Enums.FoodType.Lavash},
            new Food() {Name = "Mol go'shtli lavash", Price = 25000, FoodType = Enums.FoodType.Lavash},
            new Food() {Name = "Mol go'sht va sirli lavash", Price = 28000, FoodType = Enums.FoodType.Lavash},
            new Food() {Name = "Tovuq go'shtli lavash mini", Price = 19000, FoodType = Enums.FoodType.Lavash},
            new Food() {Name = "Tovuq go'sht va pishloqli lavash mini", Price = 22000, FoodType = Enums.FoodType.Lavash},
            new Food() {Name = "Tovuq go'shtli lavash", Price = 23000, FoodType = Enums.FoodType.Lavash},
            new Food() {Name = "Tovuq go'sht va pishloqli lavash", Price = 26000, FoodType = Enums.FoodType.Lavash},

            new Food() {Name = "Mol go'shtli shaurma mini", Price = 20000, FoodType = Enums.FoodType.Shaurma},
            new Food() {Name = "Mol go'shtli shaurma", Price = 24000, FoodType = Enums.FoodType.Shaurma},
            new Food() {Name = "Tovuq go'shtli shaurma mini", Price = 19000, FoodType = Enums.FoodType.Shaurma},
            new Food() {Name = "Tovuq go'shtli shaurma", Price = 22000, FoodType = Enums.FoodType.Shaurma},

            new Food() {Name = "Gamburger", Price = 20000, FoodType = Enums.FoodType.Burger},
            new Food() {Name = "Dablburger", Price = 29000, FoodType = Enums.FoodType.Burger},
            new Food() {Name = "Dablchizburger", Price = 33000, FoodType = Enums.FoodType.Burger},
            new Food() {Name = "Chizburger", Price = 22000, FoodType = Enums.FoodType.Burger},

            new Food() {Name = "Xot-dog", Price = 12000, FoodType = Enums.FoodType.HotDog},
            new Food() {Name = "Dablxot-dog", Price = 18000, FoodType = Enums.FoodType.HotDog},
            new Food() {Name = "Xot-dog mini", Price = 8000, FoodType = Enums.FoodType.HotDog},
            new Food() {Name = "Tovuq go'shtli xot-dog", Price = 15000, FoodType = Enums.FoodType.HotDog},
            new Food() {Name = "Tovuq go'sht va sirli xot-dog", Price = 17000, FoodType = Enums.FoodType.HotDog},
            new Food() {Name = "Mol go'shtli xot-dog", Price = 17000, FoodType = Enums.FoodType.HotDog},
            new Food() {Name = "Mol go'sht va sirli xot-dog", Price = 19000, FoodType = Enums.FoodType.HotDog},

            new Food() {Name = "Pepsi", Price = 6000, FoodType = Enums.FoodType.Drink},
            new Food() {Name = "Fanta", Price = 6000, FoodType = Enums.FoodType.Drink}
        };
    }
}
