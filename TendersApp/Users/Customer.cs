namespace TendersApp.Users
{
    public class Customer : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Division { get; set; }

        public Customer(string firstName, string lastName, string email, string phoneNumber,
            string login, string password, string division, Enums.Roles role)
            : base(email, phoneNumber, login, password, role)
        {
            FirstName = firstName;
            LastName = lastName;
            Division = division;
        }

        public Customer(string email, string phoneNumber,
            string login, string password, Enums.Roles role) : base(email, phoneNumber, login, password, role)
        {

        }
    }
}
