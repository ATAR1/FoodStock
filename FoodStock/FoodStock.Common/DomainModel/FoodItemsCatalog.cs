namespace FoodStock.Common.DomainModel
{
    /// <summary>
    /// Каталог продуктов питания
    /// </summary>
    public class FoodItemsCatalog
    {
        public FoodItem AddNewFoodItem()
        {
            return new FoodItem();
        }



        public bool Contains(FoodItem foodItem)
        {
            return false;
        }
    }
}