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
        public void AddNewFFolderAndAddNewItemTest()
        {
            FoodItemsCatalog tree = new FoodItemsCatalog();

            var folderA = tree.AddNewFolder();
            var folderB = tree.AddNewFolder();
            var folderC = tree.AddNewFolder();

            Assert.AreEqual(3, tree.Folders.Count());

            var folderBA = folderB.AddNewFolder();
            var folderBB = folderB.AddNewFolder();
            var item = folderBA.AddNewItem();
            Assert.AreEqual(1, folderBA.Items.Count());
            Assert.IsInstanceOfType(item,typeof(FoodItem));
        }


        [TestMethod]
        public void AddNewItemDeniedOnFirstLevel()
        {
            FoodItemsCatalog tree = new FoodItemsCatalog();
            Assert.IsNull(tree.AddNewItem, "Добавление нового элемента на первый уровень не должно быть доступно!");
        }
        
    }
}