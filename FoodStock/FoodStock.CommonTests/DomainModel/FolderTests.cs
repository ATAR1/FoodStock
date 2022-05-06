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
    public class FolderTests
    {
        [TestMethod()]
        public void RemoveTest()
        {
            var folderA = new Folder<FoodItem>();
            var folderB =  folderA.AddNewFolder();
            folderA.SelectedItem = folderB;
            folderA.RemoveSelectedItem();
            
            Assert.IsFalse(folderA.Folders.Contains(folderB));
            Assert.IsNull(folderA.SelectedItem);
        }
    }
}