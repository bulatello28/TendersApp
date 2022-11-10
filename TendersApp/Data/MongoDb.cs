using MongoDB.Bson;
using MongoDB.Driver;

namespace TendersApp.Data
{
    public class MongoDb
    {
        public static void AddUserToDataBase(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var collection = database.GetCollection<User>("UserCollection");
            collection.InsertOne(user);
        }

        public static void ReplaceOneInDataBase(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var filter = new BsonDocument("_id", user._id);
            var collection = database.GetCollection<User>("UserCollection");
            collection.ReplaceOne(filter, user);
        }
    }
}
