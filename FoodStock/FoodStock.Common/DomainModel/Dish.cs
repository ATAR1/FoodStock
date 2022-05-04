using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodStock.Common.DomainModel
{
    /// <summary>
    /// Блюдо, содержит набор продуктов 
    /// </summary>
    public class Dish
    {

        /// <summary>
        /// Ингридиент блюда
        /// </summary>
        public class Ingredient
        {
            /// <summary>
            /// Продукт питания
            /// </summary>
            public FoodItem FoodItem { get; set; }
            /// <summary>
            /// Вес в граммах
            /// </summary>
            public uint Weight { get; set; }
        }

        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public string Name { get; set; }

        public uint Calories => GetSummary(nameof(FoodItem.Calories));

        public uint AnimalProteins => GetSummary(nameof(FoodItem.AnimalProteins));

        public uint VegetableProteins => GetSummary(nameof(FoodItem.VegetableProteins));

        public uint AnimalFats => GetSummary(nameof(FoodItem.AnimalFats));

        public uint VegetableFats => GetSummary(nameof(FoodItem.VegetableFats));

        /// <summary>
        /// Углеводы
        /// </summary>
        public uint Carbs => GetSummary(nameof(FoodItem.Carbs));

        protected virtual uint GetSummary(string propertyName)
        {
            return (uint)Ingredients.Sum(ingr => (uint)(ingr.FoodItem.GetType().GetProperty(propertyName).GetValue(ingr.FoodItem, null)) / FoodItem.BASE_WEIGHT * ingr.Weight);
        }

        public uint Weight => CalculateWeight();

        protected virtual uint CalculateWeight()
        {
            return (uint)Ingredients.Sum(ingr => ingr.Weight);
        }
    }
}