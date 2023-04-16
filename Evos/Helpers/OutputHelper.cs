using Evos.Serveces;

namespace Evos.Helpers
{
    public class OutputHelper
    {
        public static void WelcomeTo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string outputWelcomeTo = "DOT-NET Burger'ga xush kelibsiz!";
            Console.SetCursorPosition((Console.WindowWidth - outputWelcomeTo.Length) / 2, Console.CursorTop);
            Console.WriteLine(outputWelcomeTo);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Menu()
        {
            FoodService foodService = new FoodService();
            Console.ForegroundColor = ConsoleColor.Yellow;
            int index = 0;
            foreach (var foot in foodService.GetAllFoods())
            {
                index++;
                Console.WriteLine($" {index}. {foot.Name} {foot.Price}");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nOlmoqchi bo'lgan mahsulotingizni raqamini kiriting!");
            Console.WriteLine(" 0 Bosh menu va haridingiz narxlari");
        }

        public static void MainMenu()
        {
            Console.WriteLine(" 1. Taom sotib olish\n 2. Taom qo'shish");
            Console.WriteLine(" 3. Taom o'chirish\n 4. Exit");
        }

    }
}
