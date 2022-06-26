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

    }

}