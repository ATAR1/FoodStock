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
    public class FoodItemsCatalogTests
    {
        [TestMethod()]
        public void AddNewFoodItemMustGenerateNewItem()
        {
            FoodItemsCatalog tree = new FoodItemsCatalog();
            
            tree.AddNewFoodItemCommand?.Execute();
            var newFoodItem =

            Assert.IsNotNull(newFoodItem);

        }

        [TestMethod()]
        public void AddNewFoodItemTest()
        {
            FoodItemsCatalog tree = new FoodItemsCatalog();

            var newFoodItem = tree.AddNewFoodItem();
            var newFoodItem2 = tree.AddNewFoodItem();

            Assert.IsTrue(tree.Contains(newFoodItem));
            Assert.IsTrue(tree.Contains(newFoodItem2));

        }
    }
}