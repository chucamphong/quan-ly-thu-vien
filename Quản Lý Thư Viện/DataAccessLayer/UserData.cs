using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject.Models;

namespace DataAccessLayer
{
    public class UserData
    {
        private static readonly LibraryManagementSystemContext Database = new LibraryManagementSystemContext();

        public static User FindByEmailAndPassword(string @email, string password)
        {
            return Database.Users.Where(u => u.Email.Equals(@email))
                .Where(u => u.Password.Equals(password))
                .FirstOrDefault();
        }
    }
}
