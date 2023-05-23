using Evos.Models;

namespace Evos.Interfaces;

public interface IProductManager
{
    public bool DeleteFood(string foodName);

    public bool AddFood(Food food);

    public Food GetFood(string foodName);

    public List<Food> GetAllFoods();
}
