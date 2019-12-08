using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject.Models;

namespace DataAccessLayer
{
    public sealed class UserData
    {
        private static readonly LibraryManagementSystemContext Database = new LibraryManagementSystemContext();

        public static User FindByEmailAndPassword(string email, string password)
        {
            return Database.Users.FirstOrDefault(user => user.Email.Equals(email) &&
                                                         user.Password.Equals(password));
        }
    }
}
