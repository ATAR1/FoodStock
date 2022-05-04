using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoodStock.Common.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStock.Common.DomainModel.Tests
{
    [TestClass()]
    public class DishTests
    {
        private FoodItem _item1;
        private FoodItem _item2;

        [TestInitialize]
        public void Initialize()
        {
            _item1 = new FoodItem { Name = "item1", Calories = 10, AnimalProteins = 10, VegetableProteins = 10, AnimalFats = 10, VegetableFats = 10, Carbs = 10 };
            _item2 = new FoodItem { Name = "item2", Calories = 13, AnimalProteins = 14, VegetableProteins = 15, AnimalFats = 16, VegetableFats = 17, Carbs = 18 };
        }

        

        
        [TestMethod()]
        public void DishMustToSummValuesInProportionOfTheWeightFloat()
        {
            Dish dish = new Dish();
            
            dish.Ingredients.Add(new Dish.Ingredient { FoodItem = _item2, Weight = 200 });
            Assert.AreEqual(26u, dish.Calories, "Каллории должны добавлятся пропорционально весу ингридиента");
            Assert.AreEqual(28u, dish.AnimalProteins, "Животные белки должны добавлятся пропорционально весу ингридиента");
            Assert.AreEqual(30u, dish.VegetableProteins, "Ценность должна добавлятся пропорционально весу ингридиента");
            Assert.AreEqual(32u, dish.AnimalFats, "Ценность должна добавлятся пропорционально весу ингридиента");
            Assert.AreEqual(34u, dish.VegetableFats, "Ценность должна добавлятся пропорционально весу ингридиента");
            Assert.AreEqual(36u, dish.Carbs, "Углеводы всех ингридиентов должны суммироваться пропорционально весу ингридиента");
        }

        [TestMethod()]
        public void DishMustToSummValues()
        {
            Dish dish = new Dish();
            dish.Ingredients.Add(new Dish.Ingredient { FoodItem = _item1, Weight = 100 });
            dish.Ingredients.Add(new Dish.Ingredient { FoodItem = _item2, Weight = 100 });

            Assert.AreEqual(23u, dish.Calories, "Каллории должны суммироваться");
            Assert.AreEqual(24u, dish.AnimalProteins, "Животные белки должны суммироваться");
            Assert.AreEqual(25u, dish.VegetableProteins, "Ценные вещества блюда должны суммироваться из ингридиентов");
            Assert.AreEqual(26u, dish.AnimalFats, "Ценные вещества блюда должны суммироваться из ингридиентов");
            Assert.AreEqual(27u, dish.VegetableFats, "Ценные вещества блюда должны суммироваться из ингридиентов");
            Assert.AreEqual(28u, dish.Carbs, "Углеводы всех ингридиентов должны суммироваться");
        }

    }
}

