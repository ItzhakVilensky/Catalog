using System;
using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Repositiories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid guid);
        IEnumerable<Item> GetItems();
        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(Guid guid);
    }
}