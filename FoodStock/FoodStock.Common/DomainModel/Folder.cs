using System;
using System.Collections.Generic;

namespace FoodStock.Common.DomainModel
{
    /// <summary>
    /// Папка которая может может содержать вложенные папки и/или элементы
    /// </summary>
    /// <typeparam name="T">Тип элементов которые могут содержаться в этой папке либо во вложенных папках</typeparam>
    public class Folder<T>:IItemsContainer<T>,IItemsContainer<Folder<T>> where T:new()
    {               
        /// <summary>
        /// Создаёт новый элемент, добавляет в Items и возвращает его.
        /// </summary>
        public T AddNewItem()
        {
            var newItem = new T();
            _items.Add(newItem);
            return newItem;
        }

        /// <summary>
        /// Создаёт новую папку, добавляет в Folders и возвращает её.
        /// </summary>
        public Folder<T> AddNewFolder()
        {
            var newFolder = new Folder<T>();
            _folders.Add(newFolder);
            return newFolder;
        }

        Folder<T> IItemsContainer<Folder<T>>.AddNewItem() => this.AddNewFolder();
        
        public void RemoveItem(T item)
        {
            _items.Remove(item);
        }

        
        public void RemoveItem(Folder<T> item) => RemoveFolder(item);

        private void RemoveFolder(Folder<T> folder)
        {
            _folders.Remove(folder);
        }

        private readonly List<T> _items = new List<T>();
        public IEnumerable<T> Items => _items;

        private readonly List<Folder<T>> _folders = new List<Folder<T>>();
        public IEnumerable<Folder<T>> Folders => _folders;
        
        
        IEnumerable<Folder<T>> IItemsContainer<Folder<T>>.Items => _folders;
    }
}