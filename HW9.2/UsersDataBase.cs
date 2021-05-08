using System.Collections.Generic;

namespace HW9._2
{
    public static class UsersDataBase
    {
        public static List<User> Users { get; }

        static UsersDataBase()
        {
            Users = new List<User>();
            var user = new User("admin", "admin");
            Users.Add(user);
        }
    }
}