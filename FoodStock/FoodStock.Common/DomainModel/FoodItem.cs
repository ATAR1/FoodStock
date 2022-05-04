using System.ComponentModel;

namespace FoodStock.Common.DomainModel
{
    /// <summary>
    /// Проддукт питания, содержание питательных веществ и каллорийность
    /// </summary>
    public class FoodItem
    {
        /// <summary>
        /// паищевая ценность продкукта расчитывается на 100 грамм продукта
        /// </summary>
        public const double BASE_WEIGHT = 100.0;
        
        public string Name { get; set; }

        public uint Calories { get; set; }

        public uint AnimalProteins { get; set; }

        public uint VegetableProteins { get; set; }

        public uint AnimalFats { get; set; }

        public uint VegetableFats { get; set; }

        /// <summary>
        /// Углеводы
        /// </summary>
        public uint Carbs { get; set; }
    }
}