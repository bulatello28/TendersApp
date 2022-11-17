using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using TendersApp.Enums;
using System.Text.RegularExpressions;

namespace TendersApp.Users
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [RegularExpression(@"^\S+@\S+\.\S+$", ErrorMessage = "Not correct email!")]
        public string Email { get; set; }

        [RegularExpression(@"^[1-9]\d{3}\d{3}\d{4}$", ErrorMessage = "Неверный формат номера телефона!")]
        public string PhoneNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }

        public User(string login, string password, string email, string phoneNumber, Roles role)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            Login = login;
            Password = password;
            Role = role;
        }

        public User()
        {
            
        }

    }
}
