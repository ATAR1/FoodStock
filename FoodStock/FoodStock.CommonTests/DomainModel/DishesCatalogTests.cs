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
    public class DishesCatalogTests
    {
        [TestMethod()]
        public void AddIngredientToDishTest()
        {
            var dish = new Dish();
            var ingredient = new Dish.Ingredient();
            dish.AddIngredient(ingredient);
            Assert.IsTrue(dish.Ingredients.Contains(ingredient));
        }

        [TestMethod()]
        public void RemoveIngredientFromDishTest()
        {
            var dish = new Dish();
            var ingredient = new Dish.Ingredient();
            dish.AddIngredient(ingredient);
            dish.AddIngredient(new Dish.Ingredient());

            dish.RemoveIngredient(ingredient);

            Assert.AreEqual(1,dish.Ingredients.Count());
            Assert.IsFalse(dish.Ingredients.Contains(ingredient));
        }
    }
}