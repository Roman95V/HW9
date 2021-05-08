using System.Collections.Generic;

namespace HW9._2
{
    public class User
    {
        public string Login { get; }
        public string Password { get; }
        public List<Purse> Purses = new List<Purse>();

        public User(string login, string password)
        {
            Purses.Add(new Purse("USD"));
            Purses.Add(new Purse("EUR"));
            Purses.Add(new Purse("UAH"));
            Purses.Add(new Purse("RUB"));
            Purses.Add(new Purse("ZLOT"));

            Login = login;
            Password = password;
        }

    }
}