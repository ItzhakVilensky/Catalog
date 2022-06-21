using System;
using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Repositiories
{
    public interface IItemsRepository
    {
        // bool Equals(object obj);
        // bool Equals(InMemItemsRepository other);
        // int GetHashCode();
        // string ToString();

        Item GetItem(Guid guid);
        IEnumerable<Item> GetItems();
    }

}