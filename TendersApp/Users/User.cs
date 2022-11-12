using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TendersApp.Users
{
    public class User
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string firstName, string lastName, string email, string phoneNumber, string login, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Login = login;
            Password = password;
        }

        public User()
        {
            
        }

    }
}
