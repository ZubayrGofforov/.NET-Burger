using Evos.Enums;
using Evos.Helpers;
using Evos.Interfaces;
using Evos.Models;
using Evos.Serveces;

class Program
{
    public static void Main()
    {
        OutputHelper.WelcomeTo();
        IProductManager foodService = new FoodService();

        bool isExit = true;
        while (isExit)
        {
            OutputHelper.MainMenu();
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                #region order1
                case 1:
                    Console.Clear();
                    Console.WriteLine(" ========MENU=======");
                    OutputHelper.Menu();

                    List<int> ordersIndex = new List<int>();
                    while (true)
                    {
                        int index = int.Parse(Console.ReadLine());
                        if (index != 0)
                            ordersIndex.Add(index);
                        else break;
                    }
                    Console.Clear();
                    ShowOrderedFoods(ordersIndex);
                    Console.WriteLine($"\nSizning xaridingiz umumiy miqdori: {GetTotalPrice(ordersIndex)}");
                    break;
                #endregion

                #region order2
                case 2:
                    Console.Write("Taom nomini kiriting: ");
                    string foodName = Console.ReadLine();
                    Console.Write("Izoh: ");
                    string foodDecription = Console.ReadLine();
                    Console.Write("Narxi: ");
                    decimal foodPrice = decimal.Parse(Console.ReadLine());

                again:
                    Console.WriteLine(" 1.Lavash\n 2.Burger\n 3.HotDog\n 4.Drink\n 5.Shaurma");
                    int footTypeIndex = int.Parse(Console.ReadLine());

                    string enumValue = "";
                    if (footTypeIndex == 1)
                        enumValue = "Lavash";
                    else if (footTypeIndex == 2)
                        enumValue = "Burger";
                    else if (footTypeIndex == 3)
                        enumValue = "HotDog";
                    else if (footTypeIndex == 4)
                        enumValue = "Drink";
                    else if (footTypeIndex == 5)
                        enumValue = "Shaurma";
                    else
                        goto again;

                    bool result = foodService.AddFood(new Food()
                    {
                        Name = foodName,
                        Description = foodDecription,
                        Price = foodPrice,
                        FoodType = (FoodType)Enum.Parse(typeof(FoodType), enumValue)
                    });

                    if (result) Console.WriteLine("Taom qo'shildi!");
                    else Console.WriteLine("Bunday taom allaqachon mavjud!");

                    break;
                #endregion

                #region order3
                case 3:
                    Console.Write("O'chirmoqchi bo'lgan taom nomini kiriting: ");
                    string deleteFood = Console.ReadLine();
                    result = foodService.DeleteFood(deleteFood);

                    if (result) Console.WriteLine("Taom ochirildi!");
                    else Console.WriteLine("Bunday taom mavjud emas!");
                    break;
                #endregion

                #region order4
                case 4:
                    return;

                #endregion

                default: isExit = false; break;
            }
        }
    }

    public static decimal GetTotalPrice(List<int> indexs)
    {
        FoodService foodService = new FoodService();
        List<Food> foods = foodService.GetAllFoods();

        decimal totalPrice = 0;

        foreach (var index in indexs)
        {
            if (index <= foods.Count)
                totalPrice += foods[index - 1].Price;
        }

        return totalPrice;
    }

    public static void ShowOrderedFoods(List<int> indexs)
    {
        FoodService foodService = new FoodService();
        List<Food> foods = foodService.GetAllFoods();

        foreach (var index in indexs)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(foods[index - 1].Name + " " + foods[index - 1].Price);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
