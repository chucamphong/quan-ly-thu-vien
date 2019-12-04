using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class UserData
    {
        private static readonly LibraryManagementSystemContext Database = new LibraryManagementSystemContext();

        public static User Find(string email, string password)
        {
            return Database.Users.FirstOrDefault(user => user.Email == email && user.Password == password);
        }

        public static IEnumerable<User> Where(Func<User, bool> predicate)
        {
            return Database.Users.Where(predicate);
        }
    }
}
