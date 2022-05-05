using System;
using System.Collections.Generic;

namespace FoodStock.Common.DomainModel
{
    /// <summary>
    /// Папка которая может может содержать вложенные папки и/или элементы
    /// </summary>
    /// <typeparam name="T">Тип элементов которые могут содержаться в этой папке либо во вложенных папках</typeparam>
    public class Folder<T> where T:new()
    {
        private Folder<T> _selectedFolder;

        private T AddNewItemImpl()
        {
            var newItem = new T();
            Items.Add(newItem);
            return newItem;
        }

        private Folder<T> AddNewFolderImpl()
        {
            var newFolder = new Folder<T>();
            Folders.Add(newFolder);
            return newFolder;
        }

        public ICollection<Folder<T>> Folders { get; } = new List<Folder<T>>();

        public ICollection<T> Items { get; } = new List<T>();

        public Folder<T> SelectedFolder
        {
            get
            {
                return _selectedFolder;
            }
            set
            {
                _selectedFolder = value;
                if(_selectedFolder!=null)_selectedFolder.SelectedFolder = null;
            }
        }


        /// <summary>
        /// Создаёт новую папку, добавляет в Folders и возвращает её.
        /// </summary>
        public Func<Folder<T>> AddNewFolder => SelectedFolder?.AddNewFolder ?? AddNewFolderImpl;


        /// <summary>
        /// Создаёт новый элемент, добавляет в Items и возвращает его.
        /// </summary>
        public Func<T> AddNewItem => SelectedFolder?.AddNewItem ??  AddNewItemImpl;
    }
}