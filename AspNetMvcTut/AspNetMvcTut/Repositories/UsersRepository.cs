using AspNetMvcTut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcTut.Repositories
{
    public class UsersRepository
    {
        private static List<UserModel> _users = new List<UserModel>();

        public static List<UserModel> GetAll()
        {
            return _users;
        }

        public static void Add(UserModel user)
        {
            _users.Add(user);
        }
    }
}
