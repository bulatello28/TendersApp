namespace TendersApp.Users
{
    public class Customer : User
    {
        public string Division { get; set; }

        public Customer(string firstName, string lastName, string email, string phoneNumber,
            string login, string password, string division)
            : base(firstName, lastName, email, phoneNumber, login, password)
        {
            Division = division;
        }

        public Customer(string firstName, string lastName, string email, string phoneNumber,
            string login, string password) : base(firstName, lastName, email, phoneNumber, login, password)
        {

        }
    }
}
