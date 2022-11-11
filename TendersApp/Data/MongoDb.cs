using MongoDB.Bson;
using MongoDB.Driver;
using TendersApp.Users;

namespace TendersApp.Data
{
    public class MongoDb
    {
        public User? currentUser;
        static MongoClient client = new MongoClient("mongodb://localhost");
        static IMongoDatabase database = client.GetDatabase("Users");

        public void Save<TEntity>(TEntity entity)
        {
            var collection = database.GetCollection<TEntity>(typeof(TEntity).Name);
            collection.InsertOne(entity);
        }
        public static void AddCustomerToDataBase(Customer customer)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var collection = database.GetCollection<User>("CustomerCollection");
            collection.InsertOne(customer);
        }

        public static void AddDesignerToDataBase(Designer designer)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var collection = database.GetCollection<User>("DesignerCollection");
            collection.InsertOne(designer);
        }
        public static void AddDeveloperToDataBase(Developer developer)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var collection = database.GetCollection<User>("DeveloperCollection");
            collection.InsertOne(developer);
        }
    }
}
