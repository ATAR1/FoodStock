using System;
using System.Collections.Generic;

namespace FoodStock.Common.DomainModel
{
    public interface IItemsContainer<T>
    {
        
        Func<T> AddNewItem { get; }

        T SelectedItem { get; set; }

        ICollection<T> Items { get; }

        Action RemoveSelectedItem { get; }
    }
}