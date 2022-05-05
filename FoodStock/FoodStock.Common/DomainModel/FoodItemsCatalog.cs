using System;
using System.Collections.Generic;

namespace FoodStock.Common.DomainModel
{
    /// <summary>
    /// Каталог продуктов питания
    /// </summary>
    public class FoodItemsCatalog:Folder<FoodItem>
    {   
        /// <summary>
        /// Переопределение для того чтобы запретить добавление продуктов в корневой каталог
        /// </summary>
        public new Func<FoodItem> AddNewItem => SelectedFolder!=null?SelectedFolder.AddNewItem:null;
    }
}