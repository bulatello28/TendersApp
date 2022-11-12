namespace TendersApp.Users
{
    public class Developer : User
    {
        public string Organisation { get; set; }
        public string Ogrn { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Adress { get; set; }
        public string Director { get; set; }

        public Developer(string firstName, string lastName, string email, string phoneNumber, 
            string login, string password, string organisation, string ogrn, string inn, string kpp, string adress, string director)
            :base(firstName, lastName, email, phoneNumber, login, password)
        {
            Organisation = organisation;
            Ogrn = ogrn;
            Inn = inn;
            Kpp = kpp;
            Adress = adress;
            Director = director;
        }

        public Developer(string firstName, string lastName, string email, string phoneNumber,
            string login, string password) : base(firstName, lastName, email, phoneNumber, login, password)
        {

        }
    }
}
