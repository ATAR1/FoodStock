using System.Collections.Generic;
using System.Linq;

namespace FoodStock.Common.DomainModel
{
    /// <summary>
    /// Блюдо, содержит набор продуктов 
    /// </summary>
    public class Dish
    {        
        public class Ingredient
        {
            public FoodItem FoodItem { get; set; }
            /// <summary>
            /// Вес в граммах
            /// </summary>
            public uint Weight { get; set; }
        }

        public List<Ingredient> Ingredients { get; set; }

        public string Name { get; set; }

        public uint Calories => (uint)Ingredients.Sum(ingr => ingr.FoodItem.Calories);

        public uint AnimalProteins => (uint)Ingredients.Sum(ingr => ingr.FoodItem.AnimalProteins);

        public uint VegetableProteins => (uint)Ingredients.Sum(ingr => ingr.FoodItem.VegetableProteins);

        public uint AnimalFats => (uint)Ingredients.Sum(ingr => ingr.FoodItem.AnimalFats);

        public uint VegetableFats => (uint)Ingredients.Sum(ingr => ingr.FoodItem.VegetableFats);

        /// <summary>
        /// Углеводы
        /// </summary>
        public uint Carbs => (uint)Ingredients.Sum(ingr => ingr.FoodItem.Carbs);

        public uint Weight => (uint)Ingredients.Sum(ingr => ingr.Weight);

    }
}