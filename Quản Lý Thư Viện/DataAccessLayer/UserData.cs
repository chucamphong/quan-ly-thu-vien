using System.Linq;
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
