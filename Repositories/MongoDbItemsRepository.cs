using System;
using System.Collections.Generic;
using Catalog.Entities;
using MongoDB.Driver;

namespace Catalog.Repositiories
{
    public class MongoDbItemsRepository : IItemsRepository
    {
        private const string databaseName = "catalog";
        private const string collectionName = "items";

        private readonly IMongoCollection<Item> itemsCollection;

        public MongoDbItemsRepository(IMongoClient mongoClient)
        {
            IMongoDatabase dataBase = mongoClient.GetDatabase(databaseName);
            itemsCollection = dataBase.GetCollection<Item>(collectionName);
        }

        public void CreateItem(Item item)
        {
            itemsCollection.InsertOne(item);
        }

        public void DeleteItem(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(Guid guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}