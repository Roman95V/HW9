using System.Collections.Generic;
using System.Linq;

namespace HW9._2
{
    public static class Actions
    {
        public static void AddUser(string login, string password)
        {
            UsersDataBase.Users.Add(new User(login, password));
        }

        public static User GetUser(string login, string password)
        {
            return UsersDataBase.Users.Where(user => user.Login == login).FirstOrDefault(user => user.Password == password);
        }

        public static List<Purse> GetPurses(User user)
        {
            return user.Purses;
        }
    }
}