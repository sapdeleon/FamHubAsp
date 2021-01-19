using MongoDB.Driver;
using FamHubAsp.Models;

namespace FamHubAsp.Data
{
    public class MongoContext
    {
        public IMongoDatabase db;

        public MongoContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("famhubDB");
        }

        public IMongoCollection<Product> Products
        {
            get
            {
                return db.GetCollection<Product>("Products");
            }
        }
    }
}