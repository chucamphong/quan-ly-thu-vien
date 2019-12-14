using System.Linq;
using DataTransferObject;

namespace DataAccessLayer.Data
{
    public sealed class UserData : BaseData<User>
    {
        public User FindByEmailAndPassword(string email, string password)
        {
            return this.Context.Users.AsNoTracking()
                                     .SingleOrDefault(user => user.Email.Equals(email) &&
                                                              user.Password.Equals(password));
        }
    }
}
