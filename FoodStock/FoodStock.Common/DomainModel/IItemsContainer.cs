using System;
using System.Collections.Generic;

namespace FoodStock.Common.DomainModel
{
    public interface IItemsContainer<T>
    {

        T AddNewItem();

        IEnumerable<T> Items { get; }

        void RemoveItem(T item);
    }
}