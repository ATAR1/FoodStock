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

            Assert.AreEqual(3, tree.Folders.Count);

            tree.SelectedFolder = folderB;
            var folderBA = tree.AddNewFolder();
            var folderBB = tree.AddNewFolder();
            tree.SelectedFolder = folderBA;
            var item = tree.AddNewItem();
            tree.AddNewItem();
            tree.AddNewItem();

            Assert.AreEqual(3, folderBA.Items.Count);
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