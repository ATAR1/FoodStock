namespace FoodStock.Common.DomainModel
{
    public class DishesCatalog:Folder<Dish>
    {
        public Dish SelectedDish { get; set; }


        public void AddIngredient(Dish.Ingredient ingredient)
        {
            SelectedDish?.AddIngredient(ingredient);
        }
    }
}